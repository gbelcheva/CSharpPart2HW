namespace _02BankAccounts
{
    using System;

    class TestProgram
    {
        private static readonly Random r = new Random();
        static void Main()
        {
            BankAccount[] bankAccounts = new BankAccount[]
            {
                new DepositAccount(BankAccount.Customers.individual, 502.20M, 2),
                new DepositAccount(BankAccount.Customers.company, 6020.25M, 2),
                new LoanAccount(BankAccount.Customers.individual, 150.51M, 1.5),
                new LoanAccount(BankAccount.Customers.company, 11250.10M, 1.1),
                new MortgageAccount(BankAccount.Customers.individual, 20020.80M, 3),
                new MortgageAccount(BankAccount.Customers.company, 45000.50M, 3.7)
            };
            Console.WriteLine("\n____________ Bank accounts ".PadRight(100, '_'));
            foreach (var ba in bankAccounts)
            {
                int months = r.Next(1, 36);
                Console.WriteLine(ba.ToString().PadRight(50,' ') + " Interest amount for " + months + " months: " + (ba.CalculateInterestAmount(months) / 100).ToString("P2"));
            }
            Console.WriteLine("\n____________ Check depositing and withdrawing ".PadRight(100, '_'));
            foreach (var ba in bankAccounts)
            {
                decimal deposit = 500M;
                decimal withdraw = 150M;
                Console.Write(ba.ToString().PadRight(50, ' ') + " Depositing $500: ");
                ba.Deposit(deposit);
                Console.Write(ba.Balance.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-US")));
                if (ba is DepositAccount)
                {
                    (ba as DepositAccount).Withdraw(withdraw);
                    Console.Write("   Withdrawing $150: ");
                    Console.WriteLine(ba.Balance.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-US")));
                    continue;
                }
                Console.WriteLine();
            }
        }
    }
}
