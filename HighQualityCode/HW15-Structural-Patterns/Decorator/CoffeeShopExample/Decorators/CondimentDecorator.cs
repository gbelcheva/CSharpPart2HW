namespace CoffeeShopExample.Decorators
{
    using CoffeeShopExample.Contracts;

    public abstract class CondimentDecorator : IBeverage
    {
        private IBeverage beverage;

        protected CondimentDecorator(IBeverage beverage)
        {
            this.Beverage = beverage;
        }

        public IBeverage Beverage
        {
            get
            {
                return this.beverage;
            }

            protected set
            {
                this.beverage = value;
            }
        }

        public abstract string GetDescription();

        public abstract double Cost();
    }
}
