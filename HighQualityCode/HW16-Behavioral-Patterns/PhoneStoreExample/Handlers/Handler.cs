namespace PhoneStoreExample.Handlers
{
    using PhoneStoreExample.Phones;

    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(MobilePhone phone);
    }
}
