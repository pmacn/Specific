
namespace Specific
{
    public interface ISpecification<T>
    {
        bool SatisfiedBy(T entity);
    }
}
