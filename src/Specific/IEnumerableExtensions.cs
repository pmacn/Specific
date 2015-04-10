﻿using System.Collections.Generic;
using System.Linq;

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