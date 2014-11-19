using System;
using Shouldly;
using Xunit;

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

            [Fact]
            public void WhenNullConstructorArgument_ThrowsException()
            {
                ISpecification<object> nullSpec = null;
                ISpecification<object> notNullSpec = FakeSpecification.AlwaysTrue;

                Should.Throw<ArgumentNullException>(() => nullSpec.And(notNullSpec));
                Should.Throw<ArgumentNullException>(() => notNullSpec.And(nullSpec));
            }
        }

        public class NotExtension
        {
            [Fact]
            public void TrueIsFalse()
            {
                var original = FakeSpecification.AlwaysTrue;

                var sut = original.Not();

                sut.SatisfiedBy(null).ShouldBe(false);
            }

            [Fact]
            public void FalseIsTrue()
            {
                var original = FakeSpecification.AlwaysFalse;

                var sut = original.Not();

                sut.SatisfiedBy(null).ShouldBe(true);
            }

            [Fact]
            public void WhenNullSource_ThrowsException()
            {
                ISpecification<object> nullSpec = null;
                Should.Throw<ArgumentNullException>(() => nullSpec.Not());
            }
        }

        public class OrCombinator
        {
            [Fact]
            public void TrueOrTrue_IsTrue()
            {
                var left = FakeSpecification.AlwaysTrue;
                var right = FakeSpecification.AlwaysTrue;

                var specification = left.Or(right);

                specification.SatisfiedBy(null).ShouldBe(true);
            }

            [Fact]
            public void TrueOrFalse_IsTrue()
            {
                var left = FakeSpecification.AlwaysTrue;
                var right = FakeSpecification.AlwaysFalse;

                var specification = left.Or(right);

                specification.SatisfiedBy(null).ShouldBe(true);
            }

            [Fact]
            public void FalseOrTrue_IsTrue()
            {
                var left = FakeSpecification.AlwaysFalse;
                var right = FakeSpecification.AlwaysTrue;

                var specification = left.Or(right);

                specification.SatisfiedBy(null).ShouldBe(true);
            }

            [Fact]
            public void FalseOrFalse_IsFalse()
            {
                var left = FakeSpecification.AlwaysFalse;
                var right = FakeSpecification.AlwaysFalse;

                var specification = left.Or(right);

                specification.SatisfiedBy(null).ShouldBe(false);
            }

            [Fact]
            public void WhenNullConstructorArgument_ThrowsException()
            {
                ISpecification<object> nullSpec = null;
                ISpecification<object> notNullSpec = FakeSpecification.AlwaysTrue;
                
                Should.Throw<ArgumentNullException>(() => notNullSpec.Or(nullSpec));
                Should.Throw<ArgumentNullException>(() => nullSpec.Or(notNullSpec));
            }
        }

        public class XorCombinator
        {
            [Fact]
            public void TrueXorTrue_IsFalse()
            {
                var left = FakeSpecification.AlwaysTrue;
                var right = FakeSpecification.AlwaysTrue;

                var specification = left.Xor(right);

                specification.SatisfiedBy(null).ShouldBe(false);
            }

            [Fact]
            public void TrueOrElseFalse_IsTrue()
            {
                var left = FakeSpecification.AlwaysTrue;
                var right = FakeSpecification.AlwaysFalse;

                var specification = left.Xor(right);

                specification.SatisfiedBy(null).ShouldBe(true);
            }

            [Fact]
            public void FalseOrElseTrue_IsTrue()
            {
                var left = FakeSpecification.AlwaysFalse;
                var right = FakeSpecification.AlwaysTrue;

                var specification = left.Xor(right);

                specification.SatisfiedBy(null).ShouldBe(true);
            }

            [Fact]
            public void FalseOrElseFalse_IsTrue()
            {
                var left = FakeSpecification.AlwaysFalse;
                var right = FakeSpecification.AlwaysFalse;

                var specification = left.Xor(right);

                specification.SatisfiedBy(null).ShouldBe(false);
            }

            [Fact]
            public void WhenNullConstructorArgument_ThrowsException()
            {
                ISpecification<object> nullSpec = null;
                ISpecification<object> notNullSpec = FakeSpecification.AlwaysTrue;

                Should.Throw<ArgumentNullException>(() => nullSpec.Xor(notNullSpec));
                Should.Throw<ArgumentNullException>(() => notNullSpec.Xor(nullSpec));
            }
        }
    }
}
