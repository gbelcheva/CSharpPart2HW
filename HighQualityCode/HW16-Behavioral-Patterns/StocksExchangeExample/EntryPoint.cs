namespace StocksExchangeExample
{
    using StocksExchangeExample.Observers;
    using StocksExchangeExample.Subjects;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            Apple apple = new Apple("Apple", 120.00);

            apple.Attach(new Investor("Jonathan Ive"));
            apple.Attach(new Investor("Tim Cook"));

            apple.Price = 120.10;
            apple.Price = 121.00;
            apple.Price = 120.50;
            apple.Price = 120.75;
        }
    }
}
