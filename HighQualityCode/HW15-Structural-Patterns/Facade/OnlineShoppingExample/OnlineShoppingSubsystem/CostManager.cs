namespace OnlineShoppingExample.OnlineShoppingSubsystem
{
    using System;
    using OnlineShoppingExample.Contracts;

    public class CostManager : ICostCalculator
    {
        public double ApplyDiscounts(double price, double discountPercent)
        {
            Console.WriteLine(string.Format("A discount of {0}% has been applied to the product's price of {1} lv.", discountPercent, price));

            double discountedPrice = price - this.CalculateDiscount(price, discountPercent);

            return discountedPrice;
        }

        private double CalculateDiscount(double price, double discountPercent) 
        {
            double discount = discountPercent * price / 100;

            return discount;
        }
    }
}