namespace CoffeeShopExample.Condiments
{
    using CoffeeShopExample.Contracts;
    using CoffeeShopExample.Decorators;

    public class Mocha : CondimentDecorator, IBeverage
    {
        public Mocha(IBeverage beverage)
            : base(beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.40;
        }
    }
}
