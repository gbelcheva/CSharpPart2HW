namespace CoffeeShopExample.Beverages
{
    using CoffeeShopExample.Contracts;

    public abstract class Beverage : IBeverage
    {
        private string description;

        public string Description
        {
            get
            {
                return this.description;
            }

            protected set
            {
                this.description = value;
            }
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public abstract double Cost();
    }
}
