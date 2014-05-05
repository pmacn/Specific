using Krav;

namespace Specific
{
    public class OrSpecification<T> : ISpecification<T>
    {
        readonly ISpecification<T> left;
        readonly ISpecification<T> right;
        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            RequireThat.NotNull(left, "left");
            RequireThat.NotNull(right, "right");

            this.left = left;
            this.right = right;
        }

        public bool SatisfiedBy(T entity)
        {
            return left.SatisfiedBy(entity) || right.SatisfiedBy(entity);
        }
    }
}
