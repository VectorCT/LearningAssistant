using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;

namespace LearnerAssistant.Services.Implementation;

public class QuizService(ApplicationDbContext context) : IQuizService
{
  private readonly ApplicationDbContext _context = context;

  public async Task<IReadOnlyList<QuizQuestionDto>> GetQuizByChapterAsync(Guid chapterId)
  {
    var questions = await _context.Questions
      .AsNoTracking()
      .Where(q => q.ChapterId == chapterId)
      .ToListAsync();

    return questions.Select(q => new QuizQuestionDto
    {
      Id = q.Id,
      QuestionText = q.QuestionText,
      PointValue = q.PointValue,
      Options = string.IsNullOrEmpty(q.Options) ? new List<string>() : q.Options.Split("|||", StringSplitOptions.RemoveEmptyEntries).ToList(),
      MaxSelections = q.MaxSelections,
      QuestionTypeId = q.QuestionTypeId
    }).ToList();
  }

  public async Task<QuizResultDto> SubmitQuizAsync(QuizSubmissionDto submission)
  {
    if (submission.Answers == null || !submission.Answers.Any())
      return new QuizResultDto { MaxScore = 0, TotalScore = 0, QuestionResults = new List<QuestionResultDto>() };

    var questionIds = submission.Answers.Select(a => a.QuestionId).Distinct().ToList();

    // Load questions and answers in parallel for better performance
    var questionsTask = _context.Questions
      .AsNoTracking()
      .Where(q => questionIds.Contains(q.Id))
      .ToListAsync();

    var answersTask = _context.Answers
      .AsNoTracking()
      .Where(a => questionIds.Contains(a.QuestionId))
      .ToListAsync();

    await Task.WhenAll(questionsTask, answersTask);

    var questions = await questionsTask;
    var answers = await answersTask;

    var result = new QuizResultDto();
    int maxScore = 0;

    foreach (var q in questions)
    {
      maxScore += q.PointValue;
      var userAns = submission.Answers.FirstOrDefault(a => a.QuestionId == q.Id);
      var qResult = new QuestionResultDto { QuestionId = q.Id };

      if (userAns == null)
      {
        qResult.IsCorrect = false;
        qResult.AwardedPoints = 0;
        result.QuestionResults.Add(qResult);
        continue;
      }

      var correctOptions = new List<string>();
      // collect correct options from Answers table for this question
      var qAnswers = answers.Where(a => a.QuestionId == q.Id).ToList();
      foreach (var a in qAnswers)
      {
        switch (a)
        {
          case DataAccessLayer.Models.MultipleChoiceAnswer mc:
            if (!string.IsNullOrEmpty(mc.CorrectOption)) correctOptions.Add(mc.CorrectOption);
            break;
          case DataAccessLayer.Models.TrueFalseAnswer tf:
            // Represent true/false as "True"/"False"
            correctOptions.Add((tf.IsTrue ?? false) ? "True" : "False");
            break;
        }
      }

      qResult.CorrectOptions = correctOptions;

      // simple correctness: all selected options equal set of correct options
      var selected = userAns.SelectedOptions ?? new List<string>();
      var isCorrect = selected.Count == correctOptions.Count && !selected.Except(correctOptions).Any();
      qResult.IsCorrect = isCorrect;
      qResult.AwardedPoints = isCorrect ? q.PointValue : 0;

      result.QuestionResults.Add(qResult);
    }

    result.MaxScore = maxScore;
    result.TotalScore = result.QuestionResults.Sum(r => r.AwardedPoints);
    return result;
  }
}
