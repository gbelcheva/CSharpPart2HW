namespace OnlineShoppingExample.OnlineShoppingSubsystem
{
    using System;
    using OnlineShoppingExample.Contracts;

    public class InventoryManager : IInventoryManager
    {
        public void Update(int productId)
        {
            Console.WriteLine("Product #" + productId + " was pulled from the online store inventory.");
        }
    }
}
