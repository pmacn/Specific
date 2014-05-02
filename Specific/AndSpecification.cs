using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krav;

namespace Specific
{
    public class AndSpecification<T> : ISpecification<T>
    {
        readonly ISpecification<T> left;
        readonly ISpecification<T> right;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            RequireThat.NotNull(left, "left");
            RequireThat.NotNull(right, "right");

            this.left = left;
            this.right = right;
        }

        public bool SatisfiedBy(T entity)
        {
            return left.SatisfiedBy(entity) && right.SatisfiedBy(entity);
        }
    }
}
