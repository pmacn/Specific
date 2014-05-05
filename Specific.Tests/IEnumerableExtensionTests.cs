using System.Linq;
using Shouldly;
using Xunit;

namespace Specific.Tests
{
    public class HigherThan : ISpecification<int>
    {
        readonly int limit;

        public HigherThan(int limit)
        {
            this.limit = limit;
        }

        public bool SatisfiedBy(int entity)
        {
            return entity > limit;
        }
    }

    public class DivisibleBy : ISpecification<int>
    {
        readonly int divisor;

        public DivisibleBy(int divisor)
        {
            this.divisor = divisor;
        }

        public bool SatisfiedBy(int entity)
        {
            return entity % divisor == 0;
        }
    }

    public class IsSpecialNumber : AndSpecification<int>
    {
        public IsSpecialNumber()
            : base(new HigherThan(80), new DivisibleBy(5))
        {
        }
    }

    public class IEnumerableExtensionTests
    {
        [Fact]
        public void CanFilterIEnumerableUsingSpecification()
        {
            var specialOnes = Enumerable.Range(1, 100).Where(new IsSpecialNumber());
            specialOnes.Count().ShouldBe(4);
            specialOnes.ShouldContain(85);
            specialOnes.ShouldContain(95);
            specialOnes.ShouldContain(95);
            specialOnes.ShouldContain(100);
        }
    }
}
