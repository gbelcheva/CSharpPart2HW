namespace OnlineShoppingExample.OnlineShoppingSubsystem
{
    using System;

    public class OrderDetails
    {
        public OrderDetails(
            string productName, 
            string productDescription, 
            double price,
            double discount, 
            string addressLine1, 
            string addressLine2,
            int postcode, 
            string cardNumber)
        {
            this.ProductNumber = new Random(1).Next(1, 100);
            this.ProductName = productName;
            this.ProductDescription = productDescription;
            this.Price = price;
            this.DiscountPercent = discount;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.Postode = postcode;
            this.CardNumber = cardNumber;
        }

        public int ProductNumber { get; private set; }

        public string ProductName { get; private set; }

        public string ProductDescription { get; private set; }

        public double Price { get; set; }

        public double DiscountPercent { get; private set; }

        public string AddressLine1 { get; private set; }

        public string AddressLine2 { get; private set; }

        public int Postode { get; private set; }

        public string CardNumber { get; private set; }
    }
}
