namespace Specific
{
    using Krav;

    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> specification;

        public NotSpecification(ISpecification<T> specification)
        {
            RequireThat.NotNull(specification, "specification");
            this.specification = specification;
        }

        public bool SatisfiedBy(T entity)
        {
            return !specification.SatisfiedBy(entity);
        }
    }
}
