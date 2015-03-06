using System;

//Problem 10. Fibonacci Numbers

//    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

//Note: You may need to learn how to use loops.

//Examples:
//n 	comments
//1 	0
//3 	0 1 1
//10 	0 1 1 2 3 5 8 13 21 34

namespace _10Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            ulong fibonacci1 = 0;
            ulong fibonacci2 = 1;
            if (n == 1)
            {
                Console.Write("{0}", fibonacci1);
            }
            else
            {
                Console.Write("{0} {1}", fibonacci1, fibonacci2);
            }
            for (int i = 0; i < n - 2; i++)
            {
                ulong fibonacci3 = fibonacci1 + fibonacci2;
                Console.Write(" " + fibonacci3);
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci3;
            }
            Console.WriteLine();
        }
    }
}
