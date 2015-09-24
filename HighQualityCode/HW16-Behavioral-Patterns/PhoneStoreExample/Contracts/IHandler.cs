namespace PhoneStoreExample.Contracts
{

    public interface IHandler<T>
    {
        void SetSuccessor(IHandler<T> successor);

        void HandleRequest(T obj);

        void SetSpecification(ISpecification<T> specification);
    }
}
