using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("IsPrime({0}) = {1}", n, IsPrime(n));
        }
        static bool IsPrime(long n)
        {
            bool isPrime = (n > 0);
            for (long i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
