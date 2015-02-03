using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PrimesInRange
{
    class PrimesInRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input range [a, b]: ");
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primes = FindPrimesInRange(startNum, endNum);
            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
                return;
            }
            for (int i = 0; i < primes.Count - 1; i++)
            {
                Console.Write("{0}, ", primes[i]);
            }
            Console.WriteLine("{0}", primes[primes.Count - 1]);
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            if (startNum > endNum)
            {
                return primes;
            }
            if (startNum <= 1)
            {
                startNum = 2;
            }
            for (int num = startNum; num <= endNum; num++)
            {
                bool isPrime = (num > 0);
                for (int j = 2; j < Math.Sqrt(num); j++)
                {
                    if (num % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(num);
                }
            }
            return primes;
        }
    }
}
