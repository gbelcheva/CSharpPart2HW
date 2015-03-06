using System;

//Problem 8. Catalan Numbers

//    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//    Write a program to calculate the nth Catalan number by given n (1 < n < 100).

//Examples:
//n 	Catalan(n)
//0 	1
//5 	42
//10 	16796
//15 	9694845

namespace _08CatalanNums
{
    class CatalanNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer n (1 < n < 100):");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 100))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            float catalan = 1;
            for (int k = 2; k <= n; k++)
            {
                catalan *= ((n + k) / (float)k);
            }
            Console.WriteLine("Catalan({0}) = {1}", n, catalan);
        }
    }
}
