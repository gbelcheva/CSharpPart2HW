namespace _02BankAccounts
{
    using System;

    public abstract class BankAccount : IDepositable
    {
        private double interestRate;
        public enum Customers { individual, company }
        public Customers Customer { get; private set; }

        public decimal Balance { get; protected set; }

        public double InterestRatePercent
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value <= 0 || 100 < value)
                {
                    throw new ArgumentOutOfRangeException("Interest rate should be in the range (0,100]");
                }
                this.interestRate = value;
            }
        }
        public BankAccount(Customers customer, decimal balance, double interestRatePercent)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRatePercent = interestRatePercent;
        }

        public void Deposit(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public virtual double CalculateInterestAmount(int numberOfMonths)
        {
            if (numberOfMonths <= 0)
            {
                throw new ArgumentOutOfRangeException("Number of months should be greater than 0");
            }
            return numberOfMonths * this.interestRate;
        }
        public override string ToString()
        {
            return string.Format("{0,17}: {1}, {2}, {3}", this.GetType().Name, this.Customer, this.Balance.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-US")), (this.interestRate / 100).ToString("P2"));
        }
    }
}
