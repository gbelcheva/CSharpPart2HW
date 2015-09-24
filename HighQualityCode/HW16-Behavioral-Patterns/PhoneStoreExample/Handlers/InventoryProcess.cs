namespace PhoneStoreExample.Handlers
{
    using System;

    public class InventoryProcess<MobilePhone>
    {
        public void placeOrder(MobilePhone o)
        {
            Console.WriteLine("Order placed for mobile {0}", o.ToString());
        }

        public void defaultOrder(MobilePhone o)
        {
            Console.WriteLine("The order is not placed for the mobile {0}", o.ToString());
        }
    }
}
