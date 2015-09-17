namespace OnlineShoppingExample.Contracts
{
    public interface ILogisticsManager
    {
        void ShipProduct(string productName, string shippingAddress);
    }
}
