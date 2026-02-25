using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;

namespace LearnerAssistant.Services.Implementation
{
  public class QuestionService(ApplicationDbContext context) : IQuestionService
  {
    private readonly ApplicationDbContext _context = context;

    public async Task<QuestionResponseDto?> GetByIdAsync(Guid id)
    {
      var q = await _context.Questions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
      return q == null ? null : Map(q);
    }

    public async Task<IReadOnlyList<QuestionResponseDto>> GetAllByChapterAsync(Guid chapterId)
      => await _context.Questions
        .AsNoTracking()
        .Where(q => q.ChapterId == chapterId)
        .Select(q => new QuestionResponseDto
        {
          Id = q.Id,
          ChapterId = q.ChapterId,
          QuestionTypeId = q.QuestionTypeId,
          QuestionText = q.QuestionText,
          PointValue = q.PointValue,
          Options = string.IsNullOrEmpty(q.Options) ? new List<string>() : q.Options.Split("|||", StringSplitOptions.RemoveEmptyEntries).ToList(),
          MaxSelections = q.MaxSelections
        })
        .ToListAsync();

    public async Task<QuestionResponseDto> CreateAsync(QuestionCreateDto dto)
    {
      var existsChapter = await _context.Chapters.AnyAsync(c => c.Id == dto.ChapterId);
      var existsType = await _context.QuestionTypes.AnyAsync(t => t.Id == dto.QuestionTypeId);
      if (!existsChapter || !existsType) throw new ArgumentException("Invalid ChapterId or QuestionTypeId.");

      var entity = new Question
      {
        Id = Guid.NewGuid(),
        ChapterId = dto.ChapterId,
        QuestionTypeId = dto.QuestionTypeId,
        QuestionText = dto.QuestionText,
        PointValue = dto.PointValue,
        Options = dto.Options != null && dto.Options.Count > 0 ? string.Join("|||", dto.Options) : string.Empty,
        MaxSelections = dto.MaxSelections ?? 1
      };

      // Basic validation for multiple-choice: if options provided, enforce 1 or 2 selections
      if (!string.IsNullOrEmpty(entity.Options) && (entity.MaxSelections < 1 || entity.MaxSelections > 2))
        throw new ArgumentException("MaxSelections must be 1 or 2 when options are provided.");

      _context.Questions.Add(entity);
      await _context.SaveChangesAsync();
      return Map(entity);
    }

    public async Task<QuestionResponseDto?> UpdateAsync(QuestionDto dto)
    {
      var entity = await _context.Questions.FirstOrDefaultAsync(q => q.Id == dto.Id);
      if (entity == null) return null;

      entity.QuestionText = dto.QuestionText;
      entity.PointValue = dto.PointValue;
      entity.ChapterId = dto.ChapterId;
      entity.QuestionTypeId = dto.QuestionTypeId;

      entity.Options = dto.Options != null && dto.Options.Count > 0 ? string.Join("|||", dto.Options) : string.Empty;
      entity.MaxSelections = dto.MaxSelections ?? 1;

      if (!string.IsNullOrEmpty(entity.Options) && (entity.MaxSelections < 1 || entity.MaxSelections > 2))
        throw new ArgumentException("MaxSelections must be 1 or 2 when options are provided.");

      await _context.SaveChangesAsync();
      return Map(entity);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
      var entity = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);
      if (entity == null) return false;

      _context.Questions.Remove(entity);
      await _context.SaveChangesAsync();
      return true;
    }

    private static QuestionResponseDto Map(Question q) => new()
    {
      Id = q.Id,
      ChapterId = q.ChapterId,
      QuestionTypeId = q.QuestionTypeId,
      QuestionText = q.QuestionText,
      PointValue = q.PointValue,
      Options = string.IsNullOrEmpty(q.Options) ? new List<string>() : q.Options.Split("|||", StringSplitOptions.RemoveEmptyEntries).ToList(),
      MaxSelections = q.MaxSelections
    };
  }
}