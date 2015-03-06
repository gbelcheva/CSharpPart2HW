using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());
            double n5 = double.Parse(Console.ReadLine());
            double amount = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double available = 0.05 * n1 + 0.10 * n2 + 0.20 * n3 + 0.50 * n4 + 1.00 * n5;
            if (amount >= price)
            {
                if (amount - price <= available)
                {
                    Console.WriteLine("Yes {0:F2}", available - (amount - price));
                }
                else
                {
                    Console.WriteLine("No {0:F2}", (amount - price) - available);
                }
            }
            else
            {
                Console.WriteLine("More {0:F2}", price- amount);
            }

        }
    }
}
