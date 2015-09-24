namespace PhoneStoreExample.Specifications
{
    using PhoneStoreExample.Contracts;
    using System;

    public class Specification<T> : ISpecification<T>
    {
        private Func<T, bool> expression;
        public Specification(Func<T, bool> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.expression = expression;
            }
        }

        public bool IsSatisfiedBy(T obj)
        {
            return this.expression(obj);
        }
    }
}
