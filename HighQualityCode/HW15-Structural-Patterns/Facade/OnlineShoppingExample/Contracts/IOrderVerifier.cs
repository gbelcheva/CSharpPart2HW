namespace OnlineShoppingExample.Contracts
{
    public interface IOrderVerifier
    {
        bool VerifyShippingAddress(int postcode);
    }
}
