using System;
using System.Threading;
using System.Globalization;

//Problem 7. Point in a Circle

//    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

//Examples:
//x 	y 	inside
//0 	1 	true
//-2 	0 	true
//-1 	2 	false
//1.5 	-1 	true
//-1.5 	-1.5 	false
//100 	-30 	false
//0 	0 	true
//0.2 	-0.8 	true
//0.9 	-1.93 	false
//1 	1.655 	true

namespace _07PointCircle
{
    class PointCircle
    {
        static void Main(string[] args)
        {
            float xCentre = 0;
            float yCentre = 0;
            float radius = 2;
            Console.WriteLine("Input point coordinates (x, y): ");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            bool isInside = ((Math.Pow((x - xCentre), 2) + Math.Pow((y - yCentre), 2)) <= Math.Pow(radius, 2));
            Console.WriteLine("Inside?\n{0}", isInside);
        }
    }
}
