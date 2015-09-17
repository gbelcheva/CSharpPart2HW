namespace CoffeeShopExample
{
    using System;
    using CoffeeShopExample.Beverages;
    using CoffeeShopExample.Condiments;
    using CoffeeShopExample.Contracts;

    public class StartPoint
    {
        public static void Main(string[] args)
        {
            IBeverage espressoBeverage = new Espresso();

            Console.WriteLine(string.Format(
                "{0}, ${1}", 
                espressoBeverage.GetDescription(), 
                espressoBeverage.Cost()));

            IBeverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Milk(darkRoast);
            Console.WriteLine(string.Format(
                "{0}, ${1}", 
                darkRoast.GetDescription(), 
                darkRoast.Cost()));
        }
    }
}
