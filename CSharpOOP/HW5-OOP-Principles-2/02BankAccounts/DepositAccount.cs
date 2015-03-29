namespace _02BankAccounts
{
    using System;

    public class DepositAccount : BankAccount
    {
        public DepositAccount(Customers customer, decimal balance, double interestRatePercent)
            : base(customer, balance, interestRatePercent)
        {
        }
        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("Insufficient balance");
            }
            this.Balance -= withdrawAmount;
        }
        public override double CalculateInterestAmount(int numberOfMonths)
        {
            if (0 < this.Balance && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterestAmount(numberOfMonths);
        }
    }
}
