namespace OnlineShoppingExample
{
    using OnlineShoppingExample.Facades;
    using OnlineShoppingExample.OnlineShoppingSubsystem;

    public class StartPoint
    {
        public static void Main(string[] args)
        {
            OrderDetails myOrderDetails = new OrderDetails(
                "Design Patterns Brain (Book)",
                "Imprint your brain with C# design patterns",
                120,
                20,
                "Telerik Academy",
                "Aleksander Malinov 31",
                1729,
                "4176499602228778");

            OnlineShoppingFacade facade = new OnlineShoppingFacade();
            facade.PlaceOrder(myOrderDetails);
        }
    }
}
