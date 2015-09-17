namespace CoffeeShopExample.Beverages
{
    using CoffeeShopExample.Contracts;

    public class Decaf : Beverage, IBeverage
    {
        public Decaf()
        {
            this.Description = "Dcaf";
        }

        public override double Cost()
        {
            return 1.89;
        }
    }
}
