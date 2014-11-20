namespace Specific
{
    /// <summary>
    /// An <see cref="ISpecification{T}"/> that demands that the source specification is not satisfied.
    /// </summary>
    /// <typeparam name="T">
    /// The type of entity this specification checks.
    /// </typeparam>
    internal class NotSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// The source specification.
        /// </summary>
        private readonly ISpecification<T> source;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSpecification{T}"/> class.
        /// </summary>
        /// <param name="source">
        /// The source specification.
        /// </param>
        public NotSpecification(ISpecification<T> source)
        {
            this.source = source;
        }

        /// <summary>
        /// Decides if a provided <paramref name="entity"/> satisfies the specification.
        /// </summary>
        /// <param name="entity">
        /// The entity to check.
        /// </param>
        /// <returns>
        /// Returns true if the <paramref name="entity"/> satisfies the specification. Otherwise false.
        /// </returns>
        public bool SatisfiedBy(T entity)
        {
            return !this.source.SatisfiedBy(entity);
        }
    }
}
