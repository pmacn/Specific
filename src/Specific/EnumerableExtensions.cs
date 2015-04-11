namespace Specific
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extensions to simplify use of <see cref="ISpecification{T}"/> with <see cref="System.Collections.Generic.IEnumerable{T}"/>
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Filters a sequence of values based on a <see cref="ISpecification{T}"/>.
        /// </summary>
        /// <param name="source">
        /// An <see cref="System.Collections.Generic.IEnumerable{T}"/> to filter.
        /// </param>
        /// <param name="specification">
        /// The specification used to check the elements.
        /// </param>
        /// <typeparam name="T">
        /// The type of elements of source.
        /// </typeparam>
        /// <returns>
        /// An <see cref="System.Collections.Generic.IEnumerable{T}"/> that contains elements from
        /// the input sequence that satisfy the specification.
        /// </returns>
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, ISpecification<T> specification)
        {
            return source.Where(specification.SatisfiedBy);
        }
    }
}
