namespace OnlineShoppingExample.OnlineShoppingSubsystem
{
    using System;
    using OnlineShoppingExample.Contracts;

    public class Logisticsmanager : ILogisticsManager
    {
        public void ShipProduct(string productName, string shippingAddress)
        {
            Console.WriteLine(string.Format("Your {0} has been shipped to the following address: {1}", productName, shippingAddress));
        }
    }
}