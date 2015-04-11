namespace Specific
{
    /// <summary>
    /// An interface for implementing the specification pattern.
    /// </summary>
    /// <remarks>
    /// Information about specification pattern at: http://en.wikipedia.org/wiki/Specification_pattern
    /// </remarks>
    /// <typeparam name="T">
    /// The type of entity this specification checks.
    /// </typeparam>
    public interface ISpecification<in T>
    {
        /// <summary>
        /// Decides if a provided <paramref name="entity"/> satisfies the specification.
        /// </summary>
        /// <param name="entity">
        /// The entity to check.
        /// </param>
        /// <returns>
        /// Returns true if the <paramref name="entity"/> satisfies the specification. Otherwise false.
        /// </returns>
        bool SatisfiedBy(T entity);
    }
}
