using System;

//Problem 1. Exchange If Greater

//    Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

//Examples:
//a 	b 	result
//5 	2 	2 5
//3 	4 	3 4
//5.5 	4.5 	4.5 5.5

namespace _01ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a and b:");
            double a;
            double b;
            while (!(double.TryParse(Console.ReadLine(), out a) &&
                     double.TryParse(Console.ReadLine(), out b)))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            if (a - b > 0)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine("Result: {0} {1}", a, b);
        }
    }
}
