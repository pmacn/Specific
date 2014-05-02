using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific
{
    public interface ISpecification<T>
    {
        bool SatisfiedBy(T entity);
    }
}
