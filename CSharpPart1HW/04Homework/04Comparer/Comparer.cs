using System;
using System.Globalization;
using System.Threading;
//Problem 4. Number Comparer

//    Write a program that gets two numbers from the console and prints the greater of them.
//    Try to implement this without if statements.

//Examples:
//a 	b 	greater
//5 	6 	6
//10 	5 	10
//0 	0 	0
//-5 	-2 	-2
//1.5 	1.6 	1.6

namespace _04Comparer
{
    class Comparer
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input two numbers:");
            float a;
            float b;
            while (!(float.TryParse(Console.ReadLine(), out a) && 
                     float.TryParse(Console.ReadLine(), out b)))
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
            float isGreater = (a - b) > 0 ? a : b;
            Console.WriteLine("Greater: {0}", isGreater);
        }

    }
}
