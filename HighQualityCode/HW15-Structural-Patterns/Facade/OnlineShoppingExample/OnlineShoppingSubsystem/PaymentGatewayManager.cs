namespace OnlineShoppingExample.OnlineShoppingSubsystem
{
    using System;
    using OnlineShoppingExample.Contracts;

    public class PaymentGatewayManager : IPaymentGatewayManager
    {
        public bool VerifyCardDetails(string cardNumber)
        {
            bool isValidCardNumber = this.CardNumberVerifier(cardNumber);

            if (isValidCardNumber)
            {
                Console.WriteLine("Card number " + cardNumber + " has been verified and accepted.");
            }
            else
            {
                Console.WriteLine("Card number " + cardNumber + " is not valid.");
            }

            return isValidCardNumber;
        }

        public bool ProcessPayment(string cardNumber, double cost)
        {
            Console.WriteLine(string.Format("Card {0} was used to make a payment of {1} lv.", cardNumber, cost));
      
            return true;
        }

        private bool CardNumberVerifier(string cardNumber)
        {
            return true;
        }
    }
}