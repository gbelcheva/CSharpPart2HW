namespace _02BankAccounts
{
    using System;

    public class MortgageAccount : BankAccount
    {
        private const int individualsZeroInterestMonths = 6;
        private const int companiesHalfInterestMonths = 12;
        public MortgageAccount(Customers customer, decimal balance, double interestRatePercent)
            : base(customer, balance, interestRatePercent)
        {
        }
        public override double CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Customer == Customers.company)
            {
                if (numberOfMonths <= companiesHalfInterestMonths)
                {
                    return base.CalculateInterestAmount(numberOfMonths) / 2;
                }
                return base.CalculateInterestAmount(companiesHalfInterestMonths) / 2 + base.CalculateInterestAmount(numberOfMonths);
            }
            if (numberOfMonths <= individualsZeroInterestMonths)
            {
                return 0;
            }
            return base.CalculateInterestAmount(numberOfMonths - individualsZeroInterestMonths);
        }
    }
}
