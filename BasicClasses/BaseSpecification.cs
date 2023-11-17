using ASP.Net.Interfaces;
using System.Linq.Expressions;

namespace ASP.Net.BasicClasses
{
    public abstract class BaseSpecification<T> : ISpecification<T> where T : class
    {
        public Expression<Func<T, bool>> Criteria { get; set; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public List<string> IncludeStrings { get; } = new List<string>();

        public void AddInclude(Expression<Func<T, object>> include) => Includes.Add(include);        

        public void AddInclude(string include) => IncludeStrings.Add(include);
    }
}
