using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Extensions;

public static class QueryableExtensions
{
  public static async Task<IReadOnlyList<T>> ToReadOnlyListAsync<T>(
      this IQueryable<T> query)
      => await query.ToListAsync();

  public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> query)
      => query.ToList();
}
