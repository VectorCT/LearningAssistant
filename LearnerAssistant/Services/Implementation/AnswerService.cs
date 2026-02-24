using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;

namespace LearnerAssistant.Services.Implementation
{
  public class AnswerService(ApplicationDbContext context) : IAnswerService
  {
    private readonly ApplicationDbContext _context = context;

    public async Task<AnswerResponseDto?> GetByIdAsync(Guid id)
    {
      var baseAnswer = await _context.Answers.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
      return baseAnswer == null ? null : MapToResponse(baseAnswer);
    }

    public async Task<IReadOnlyList<AnswerResponseDto>> GetAllByQuestionAsync(Guid questionId)
    {
      var answers = await _context.Answers.AsNoTracking().Where(a => a.QuestionId == questionId).ToListAsync();
      return answers.Select(MapToResponse).ToList();
    }

    public async Task<AnswerResponseDto> CreateMultipleChoiceAsync(MultipleChoiceAnswerCreateDto dto)
    {
      // validate question exists
      if (!await _context.Questions.AnyAsync(q => q.Id == dto.QuestionId))
        throw new ArgumentException("Invalid QuestionId.");

      var entity = new MultipleChoiceAnswer
      {
        Id = Guid.NewGuid(),
        QuestionId = dto.QuestionId,
        Description = dto.Description,
        Options = dto.Options ?? [],
        CorrectOption = dto.CorrectOption,
        Explanation = dto.Explanation ?? string.Empty
      };

      _context.Add(entity);
      await _context.SaveChangesAsync();
      return MapToResponse(entity);
    }

    public async Task<AnswerResponseDto> CreateTrueFalseAsync(TrueFalseAnswerCreateDto dto)
    {
      if (!await _context.Questions.AnyAsync(q => q.Id == dto.QuestionId))
        throw new ArgumentException("Invalid QuestionId.");

      var entity = new TrueFalseAnswer
      {
        Id = Guid.NewGuid(),
        QuestionId = dto.QuestionId,
        Description = dto.Description,
        IsTrue = dto.IsTrue,
        Explanation = dto.Explanation ?? string.Empty
      };

      _context.Add(entity);
      await _context.SaveChangesAsync();
      return MapToResponse(entity);
    }

    public async Task<AnswerResponseDto?> UpdateMultipleChoiceAsync(MultipleChoiceAnswerDto dto)
    {
      var entity = await _context.Answers.OfType<MultipleChoiceAnswer>().FirstOrDefaultAsync(a => a.Id == dto.Id);
      if (entity == null) return null;

      entity.Description = dto.Description;
      if (dto.Options != null) entity.Options = dto.Options;
      entity.CorrectOption = dto.CorrectOption;
      entity.Explanation = dto.Explanation ?? string.Empty;

      await _context.SaveChangesAsync();
      return MapToResponse(entity);
    }

    public async Task<AnswerResponseDto?> UpdateTrueFalseAsync(TrueFalseAnswerDto dto)
    {
      var entity = await _context.Answers.OfType<TrueFalseAnswer>().FirstOrDefaultAsync(a => a.Id == dto.Id);
      if (entity == null) return null;

      entity.Description = dto.Description;
      entity.IsTrue = dto.IsTrue;
      entity.Explanation = dto.Explanation ?? string.Empty;

      await _context.SaveChangesAsync();
      return MapToResponse(entity);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
      var entity = await _context.Answers.FirstOrDefaultAsync(a => a.Id == id);
      if (entity == null) return false;

      _context.Answers.Remove(entity);
      await _context.SaveChangesAsync();
      return true;
    }

    private static AnswerResponseDto MapToResponse(Answer a)
    {
      return a switch
      {
        MultipleChoiceAnswer mc => new AnswerResponseDto
        {
          Id = mc.Id,
          QuestionId = mc.QuestionId,
          Description = mc.Description,
          AnswerType = "MultipleChoice",
          Options = mc.Options,
          CorrectOption = mc.CorrectOption,
          Explanation = mc.Explanation
        },
        TrueFalseAnswer tf => new AnswerResponseDto
        {
          Id = tf.Id,
          QuestionId = tf.QuestionId,
          Description = tf.Description,
          AnswerType = "TrueFalse",
          IsTrue = tf.IsTrue,
          Explanation = tf.Explanation
        },
        _ => new AnswerResponseDto
        {
          Id = a.Id,
          QuestionId = a.QuestionId,
          Description = a.Description,
          AnswerType = "Unknown"
        }
      };
    }
  }
}