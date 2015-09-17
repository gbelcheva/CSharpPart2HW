namespace OnlineShoppingExample.Contracts
{
    public interface ICostCalculator
    {
        double ApplyDiscounts(double price, double discountPercent);
    }
}
