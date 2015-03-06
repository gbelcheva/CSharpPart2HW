using System;
using System.Numerics;

//Problem 6. Calculate N! / K!

//    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//    Use only one loop.

//Examples:
//n 	k 	n! / k!
//5 	2 	60
//6 	5 	6
//8 	3 	6720

namespace _06NKFactorial
{
    class NKFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers n and k (1 < k < n < 100):");
            int n;
            int k;
            while (!(int.TryParse(Console.ReadLine(), out n) && int.TryParse(Console.ReadLine(), out k)))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            BigInteger factorialNK = 1;
            for (int i = k + 1; i <= n; i++)
            {
                factorialNK *= (ulong)i;
            }
            Console.WriteLine("N!/K! = {0}", factorialNK);
        }
    }
}
