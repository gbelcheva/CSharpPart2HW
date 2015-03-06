using System;

//Problem 1. Odd or Even Integers

//    Write an expression that checks if given integer is odd or even.

//Examples:
//n 	Odd?
//3 	true
//2 	false
//-2 	false
//-1 	true
//0 	false

namespace _01OddEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer:");
            int i = int.Parse(Console.ReadLine());
            bool isOdd = !(i % 2 == 0); 
            Console.WriteLine("Odd?\n{0}", isOdd);
        }
    }
}
