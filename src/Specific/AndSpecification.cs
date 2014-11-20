namespace Specific
{
    using Krav;

    /// <summary>
    /// An <see cref="ISpecification{T}"/> that demands that both of a pair of specifications is satisfied.
    /// </summary>
    /// <typeparam name="T">
    /// The type of entity this specification checks.
    /// </typeparam>
    internal class AndSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// The left hand side of the operation.
        /// </summary>
        private readonly ISpecification<T> left;

        /// <summary>
        /// The right hand side of the operation.
        /// </summary>
        private readonly ISpecification<T> right;

        /// <summary>
        /// Initializes a new instance of the <see cref="AndSpecification{T}"/> class.
        /// </summary>
        /// <param name="left">
        /// The left hand side of the operation.
        /// </param>
        /// <param name="right">
        /// The right hand side of the operation.
        /// </param>
        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
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
            return this.left.SatisfiedBy(entity) && this.right.SatisfiedBy(entity);
        }
    }
}
