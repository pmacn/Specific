using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, ISpecification<T> specification)
        {
            return items.Where(specification.SatisfiedBy);
        }
    }
}
