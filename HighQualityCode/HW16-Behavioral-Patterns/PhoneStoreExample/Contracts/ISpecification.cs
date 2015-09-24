namespace PhoneStoreExample.Contracts
{

    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T obj);
    }
}
