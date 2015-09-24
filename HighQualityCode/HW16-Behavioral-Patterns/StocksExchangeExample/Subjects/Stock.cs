namespace StocksExchangeExample.Subjects
{
    using StocksExchangeExample.Contracts;
    using System;
    using System.Collections.Generic;

    public abstract class Stock
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {

            get 
            { 
                return this.price; 
            }

            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get 
            { 
                return symbol; 
            }
        }
    }
}
