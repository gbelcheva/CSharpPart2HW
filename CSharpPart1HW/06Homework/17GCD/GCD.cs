using System;

//Problem 17.* Calculate GCD

//    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//    Use the Euclidean algorithm (find it in Internet).

//Examples:
//a 	b 	GCD(a, b)
//3 	2 	1
//60 	40 	20
//5 	-15 	5

namespace _17GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integers:");
            int a;
            int b;
            while (!(int n;
            while (! (int.TryParse(Console.ReadLine(), out a) && 
                      int.TryParse(Console.ReadLine(), out b)))
            {
                Console.WriteLine("Invalid input. Try again:");
            } 
            if (b > a)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            int quotient = a / b;
            int remainder = a % b;
            while (remainder > 0)
            {
                quotient = b / remainder;
                b = remainder;
                remainder = b % remainder;
            }
            Console.WriteLine("GCD = {0}", b);
        }
    }
}
