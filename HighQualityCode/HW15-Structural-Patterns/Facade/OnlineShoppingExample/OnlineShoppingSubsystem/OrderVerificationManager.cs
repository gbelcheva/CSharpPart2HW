namespace OnlineShoppingExample.OnlineShoppingSubsystem
{
    using System;
    using OnlineShoppingExample.Contracts;

    public class OrderVerificationManager : IOrderVerifier
    {
        public bool VerifyShippingAddress(int postcode)
        {
            bool isValidPostcode = this.PostcodeVerifier(postcode);

            if (isValidPostcode)
            {
                Console.WriteLine("The product can be shipped to postcode " + postcode);
            }
            else
            {
                Console.WriteLine("The product cannot be shipped to postcode " + postcode);
            }

            return isValidPostcode;
        }

        private bool PostcodeVerifier(int postcode) 
        {
            return true;
        }
    }
}