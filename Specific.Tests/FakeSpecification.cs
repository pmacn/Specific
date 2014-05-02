using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific.Tests
{
    public class FakeSpecification : ISpecification<object>
    {
        readonly bool value;

        private FakeSpecification(bool value)
        {
            this.value = value;
        }

        public static ISpecification<object> AlwaysTrue { get { return new FakeSpecification(true); ; } }

        public static ISpecification<object> AlwaysFalse { get { return new FakeSpecification(false); } }
        
        public bool SatisfiedBy(object entity)
        {
            return value;
        }
    }
}
