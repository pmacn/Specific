namespace Specific
{
    using Krav;

    internal class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> left;

        private readonly ISpecification<T> right;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            RequireThat.NotNull(left, "left");
            RequireThat.NotNull(right, "right");

            this.left = left;
            this.right = right;
        }

        public bool SatisfiedBy(T entity)
        {
            return this.left.SatisfiedBy(entity) && this.right.SatisfiedBy(entity);
        }
    }
}
