using System;
using System.Threading;
using System.Globalization;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

//Examples:
//x 	y 	inside K & outside of R
//1 	2 	yes
//2.5 	2 	no
//0 	1 	no
//2.5 	1 	no
//2 	0 	no
//4 	0 	no
//2.5 	1.5 	no
//2 	1.5 	yes
//1 	2.5 	yes
//-100 	-100 	no

namespace _10PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            float xCentre = 1;
            float yCentre = 1;
            float radius = 1.5f;
            float minX = -1;
            float maxX = 5;
            float maxY = 1;
            float minY = -1;
            Console.WriteLine("Input point coordinates (x, y): ");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            bool insideK = ((Math.Pow((x - xCentre), 2) + Math.Pow((y - yCentre), 2)) <= Math.Pow(radius, 2));
            bool insideR = ((x >= minX) && (x <= maxX) && (y >= minY) && (y <= maxY));
            string insideKOutsideR = (insideK && !insideR) ? "yes" : "no";
            Console.WriteLine("Inside K and outside R?\n{0}", insideKOutsideR);
        }
    }
}
