namespace CoffeeShopExample.Beverages
{
    using CoffeeShopExample.Contracts;

    public class DarkRoast : Beverage, IBeverage
    {
        public DarkRoast()
        {
            this.Description = "Dark Roast";
        }

        public override double Cost()
        {
            return 2.49;
        }
    }
}
