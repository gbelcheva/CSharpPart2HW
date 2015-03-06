using System;
using System.Threading;
using System.Globalization;

//Problem 9. Trapezoids

//    Write an expression that calculates trapezoid's area by given sides a and b and height h.

//Examples:
//a 	b 	h 	area
//5 	7 	12 	72
//2 	1 	33 	49.5
//8.5 	4.3 	2.7 	17.28
//100 	200 	300 	45000
//0.222 	0.333 	0.555 	0.1540125

namespace _09Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input trapezoid sides and height (a, b, h): ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            while ((a <= 0) || (b <= 0) || (h <= 0))
            {
                Console.WriteLine("Invalid numbers.\n");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                h = float.Parse(Console.ReadLine());
            }
            float area = (h / 2) * (a + b);
            Console.WriteLine("Area: {0}", area);
        }
    }
}
