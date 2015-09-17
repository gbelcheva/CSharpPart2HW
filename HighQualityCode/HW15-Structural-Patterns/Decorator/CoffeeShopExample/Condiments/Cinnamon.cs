namespace CoffeeShopExample.Condiments
{
    using CoffeeShopExample.Contracts;
    using CoffeeShopExample.Decorators;

    public class Cinnamon : CondimentDecorator, IBeverage
    {
        public Cinnamon(IBeverage beverage)
            : base(beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.Beverage.GetDescription() + ", Cinnamon";
        }

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.20;
        }
    }
}
