namespace Specific
{
    public interface ISpecification<in T>
    {
        bool SatisfiedBy(T entity);
    }
}
