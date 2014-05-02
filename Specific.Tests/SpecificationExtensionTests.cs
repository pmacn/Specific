using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace Specific.Tests
{
    public class SpecificationExtensionTests
    {
        public class AndCombinator
        {
            [Fact]
            public void TrueAndTrue_IsTrue()
            {
                var left = FakeSpecification.AlwaysTrue;
                var right = FakeSpecification.AlwaysTrue;

                var specification = left.And(right);

                specification.SatisfiedBy(null).ShouldBe(true);
            }

            [Fact]
            public void TrueAndFalse_IsFalse()
            {
                var left = FakeSpecification.AlwaysTrue;
                var right = FakeSpecification.AlwaysFalse;

                var specification = left.And(right);

                specification.SatisfiedBy(null).ShouldBe(false);
            }

            [Fact]
            public void FalseAndTrue_IsFalse()
            {
                var left = FakeSpecification.AlwaysFalse;
                var right = FakeSpecification.AlwaysTrue;

                var specification = left.And(right);

                specification.SatisfiedBy(null).ShouldBe(false);
            }

            [Fact]
            public void FalseAndFalse_IsFalse()
            {
                var left = FakeSpecification.AlwaysFalse;
                var right = FakeSpecification.AlwaysFalse;

                var specification = left.And(right);

                specification.SatisfiedBy(null).ShouldBe(false);
            }
        }
    }
}
