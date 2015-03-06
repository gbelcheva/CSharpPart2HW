using System;
using System.Globalization;
using System.Threading;

//Problem 3. Circle Perimeter and Area

//    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

//Examples:
//r 	perimeter 	area
//2 	12.57 	12.57
//3.5 	21.99 	38.48

namespace _03CircleAreaPerimeter
{
    class CircleAreaPerimeter
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input radius:");
            float r;
            while (!(float.TryParse(Console.ReadLine(), out r) && r > 0))
            {
                Console.WriteLine("Invalid number. Try again:");
            }
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("Perimeter {0:0.00}    Area: {1:0.00}", perimeter, area);
        }
    }
}
