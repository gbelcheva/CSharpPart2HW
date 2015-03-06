using System;

//Problem 4. Triangle surface

//    Write methods that calculate the surface of a triangle by given:
//        Side and an altitude to it;
//        Three sides;
//        Two sides and an angle between them;
//    Use System.Math.


namespace _04TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To claculate the surface of a triangle choose a formula:\nPress Z for Side and an altitude to it\nPress X for Three sides\nPress C for Two sides and an angle between them\n");
            ConsoleKeyInfo k = Console.ReadKey(true);
            while (true)
            {
                switch (k.Key)
                {
                    case ConsoleKey.Z:
                        Console.WriteLine("Input a side and its altitude:");
                        double a = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine("The surface of the triangle is: {0:N2}", SideAltitudeSurface(a, h));
                        return;
                    case ConsoleKey.X:
                        Console.WriteLine("Input three sides:");
                        a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("The surface of the triangle is: {0:N2}", ThreeSidesSurface(a, b, c));
                        return;
                    case ConsoleKey.C:
                        Console.WriteLine("Input a side and an angle:");
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        double alpha = double.Parse(Console.ReadLine());
                        Console.WriteLine("The surface of the triangle is: {0:N2}", TwoSidesAngleSurface(a, b, alpha * Math.PI / 180));
                        return;
                    default: Console.WriteLine("Wrong key. Try again.");
                        break;
                }
                k = Console.ReadKey(true);
            }
            
        }

        static double SideAltitudeSurface(double a, double h)
        {
            double surface;
            surface = (a * h) / 2.0;
            return surface;
        }
        static double ThreeSidesSurface(double a, double b, double c)
        {
            double surface;
            double p = (a + b + c) / 2;
            surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return surface;
        }
        static double TwoSidesAngleSurface(double a, double b, double alpha)
        {
            double surface;
            surface = a * b * Math.Sin(alpha) / 2;
            return surface;
        }
    }
}
