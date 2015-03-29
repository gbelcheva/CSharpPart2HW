namespace _02BankAccounts
{
    using System;

    public class LoanAccount : BankAccount
    {
        private const int insdividualsZeroInterestMonths = 3;
        private const int companiesZeroInterestMonths = 2;

        public LoanAccount(Customers customer, decimal balance, double interestRatePercent)
            : base(customer, balance, interestRatePercent)
        {
        }
        public override double CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Customer == Customers.individual)
            {
                if (numberOfMonths <= insdividualsZeroInterestMonths)
                {
                    return 0;
                }
                return base.CalculateInterestAmount(numberOfMonths - insdividualsZeroInterestMonths);
            }
            if (numberOfMonths <= companiesZeroInterestMonths)
            {
                return 0;
            }
            return base.CalculateInterestAmount(numberOfMonths - companiesZeroInterestMonths);
        }
    }
}
