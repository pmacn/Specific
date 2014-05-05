using Krav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
