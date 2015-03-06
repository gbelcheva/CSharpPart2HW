using System;
using System.Threading;
using System.Globalization;

//Problem 4. Rectangles

//    Write an expression that calculates rectangle’s perimeter and area by given width and height.

//Examples:
//width 	height 	perimeter 	area
//3 	4 	14 	12
//2.5 	3 	11 	7.5
//5 	5 	20 	25

namespace _04Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input rectangle width and height:");
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float perimeter = 2 * (width + height);
            float area = width * height;
            Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
        }
    }
}
