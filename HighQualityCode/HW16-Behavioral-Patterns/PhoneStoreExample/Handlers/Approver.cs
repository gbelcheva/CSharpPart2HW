namespace PhoneStoreExample.Handlers
{
    using PhoneStoreExample.Contracts;
    using System;

    class Approver<T>: IHandler<T> where T: IProcessable
    {
        private IHandler<T> successor;
        private string name;
        private ISpecification<T> specification;
        Action<T> action;
        public Approver(string name, Action<T> action)
        {
            this.name = name;
            this.action = action;
        }

        public bool CanHandle(T o)
        {
            if (this.specification != null && o != null)
            {
                return this.specification.IsSatisfiedBy(o);
            }
            return false;
        }

        public void SetSuccessor(IHandler<T> handler)
        {
            this.successor = handler;
        }

        public void HandleRequest(T o)
        {
            if (CanHandle(o))
            {
                //o.Process();
                Console.WriteLine("{0}: Request handled by {1}.  ", o.ToString(), this.name);
                this.action.Invoke(o);
                Console.WriteLine("\n================================\n");
            }

            if (this.successor != null)
            {
                this.successor.HandleRequest(o);
            }
        }

        public void SetSpecification(ISpecification<T> specification)
        {
            this.specification = specification;
        }
    }
}
