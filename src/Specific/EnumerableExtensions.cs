namespace Specific
{
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, ISpecification<T> specification)
        {
            return source.Where(specification.SatisfiedBy);
        }
    }
}
