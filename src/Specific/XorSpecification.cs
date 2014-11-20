namespace Specific
{
    using Krav;

    /// <summary>
    /// A specification that demands that one and only one of two specifications is satisfied.
    /// </summary>
    /// <typeparam name="T">
    /// The type of entity this specification checks.
    /// </typeparam>
    internal class XorSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// The left hand specification of the operation.
        /// </summary>
        private readonly ISpecification<T> left;

        /// <summary>
        /// The right hand specification of the operation.
        /// </summary>
        private readonly ISpecification<T> right;

        /// <summary>
        /// Initializes a new instance of the <see cref="XorSpecification{T}"/> class.
        /// </summary>
        /// <param name="left">
        /// The left hand specification.
        /// </param>
        /// <param name="right">
        /// The right hand specification.
        /// </param>
        public XorSpecification(ISpecification<T> left, ISpecification<T> right)
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
            return this.left.SatisfiedBy(entity) ^ this.right.SatisfiedBy(entity);
        }
    }
}
