using ASP.Net.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net.DataAccess.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Specify<T>(this IQueryable<T> source, ISpecification<T> specification) where T : class
        {
            //объекты в критерии сравнения с агрегацией, чтобы будущий запрос к базе, скомпилиронванный из этой цепочки IQueryable, сохранил в себе Include как колонки в запросе Select
            var queryableWithIncludes = specification.Includes.Aggregate(source, (current, include) => current.Include(include));

            var secondary = specification.IncludeStrings.Aggregate(queryableWithIncludes, (current, includes) => current.Include(includes));

            return secondary.Where(specification.Criteria);
        }
    }
}
