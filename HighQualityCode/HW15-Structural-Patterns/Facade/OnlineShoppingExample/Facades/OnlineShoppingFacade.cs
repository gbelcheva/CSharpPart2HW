namespace OnlineShoppingExample.Facades
{
    using OnlineShoppingExample.Contracts;
    using OnlineShoppingExample.OnlineShoppingSubsystem;

    public class OnlineShoppingFacade
    {
        private IInventoryManager inventory = new InventoryManager();
        private IOrderVerifier orderVerifier = new OrderVerificationManager();
        private ICostCalculator costManager = new CostManager();
        private IPaymentGatewayManager paymentGateway = new PaymentGatewayManager();
        private ILogisticsManager logistics = new Logisticsmanager();

        public void PlaceOrder(OrderDetails orderDetails) 
        {
            this.inventory.Update(orderDetails.ProductNumber);

            bool addressIsValid = this.orderVerifier.VerifyShippingAddress(orderDetails.Postode);

            orderDetails.Price = this.costManager.ApplyDiscounts(orderDetails.Price, orderDetails.DiscountPercent);
            
            bool cardIsValid = this.paymentGateway.VerifyCardDetails(orderDetails.CardNumber);
            if (addressIsValid && cardIsValid)
            {
                var paymentIsProcessed = this.paymentGateway.ProcessPayment(orderDetails.CardNumber, orderDetails.Price);

                if (paymentIsProcessed)
                {
                    string fullAddress = string.Format(
                    "{0}, {1} - {2}",
                    orderDetails.AddressLine1,
                    orderDetails.AddressLine2,
                    orderDetails.Postode);
                    this.logistics.ShipProduct(orderDetails.ProductName, fullAddress);
                }
            }
        }
    }
}
