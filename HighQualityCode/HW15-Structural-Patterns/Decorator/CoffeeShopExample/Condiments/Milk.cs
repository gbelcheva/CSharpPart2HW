namespace CoffeeShopExample.Condiments
{
    using CoffeeShopExample.Contracts;
    using CoffeeShopExample.Decorators;

    public class Milk : CondimentDecorator, IBeverage
    {
        public Milk(IBeverage beverage)
            : base(beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.Beverage.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.30;
        }
    }
}
