using System;
using System.Globalization;
using System.Threading;

//Problem 6. Quadratic Equation

//    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

//Examples:
//a 	b 	c 	roots
//2 	5 	-3 	x1=-3; x2=0.5
//-1 	3 	0 	x1=3; x2=0
//-0.5 	4 	-8 	x1=x2=4
//5 	2 	8 	no real roots

namespace _06QuadraticEq
{
    class QuadraticEq
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input coefficients a, b and c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0) Console.WriteLine("No real roots.");
            else 
            {
                double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                if (discriminant == 0)
                {
                    Console.WriteLine("x1 = x2 = {0}", x1);
                    return;
                }
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
        }
    }
}
