using Krav;

namespace Specific
{
    public class XorSpecification<T> : ISpecification<T>
    {
        readonly ISpecification<T> right;
        readonly ISpecification<T> left;

        public XorSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            RequireThat.NotNull(left, "left");
            RequireThat.NotNull(right, "right");

            this.left = left;
            this.right = right;
        }

        public bool SatisfiedBy(T entity)
        {
            return left.SatisfiedBy(entity) ^ right.SatisfiedBy(entity);
        }
    }
}
