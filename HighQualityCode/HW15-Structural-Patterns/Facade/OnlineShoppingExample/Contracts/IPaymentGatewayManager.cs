namespace OnlineShoppingExample.Contracts
{
    public interface IPaymentGatewayManager
    {
        bool VerifyCardDetails(string cardNumber);

        bool ProcessPayment(string cardNumber, double cost);
    }
}
