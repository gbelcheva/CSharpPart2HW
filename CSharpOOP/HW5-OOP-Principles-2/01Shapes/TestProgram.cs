namespace _01Shapes
{
    using System;

    class TestProgram
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] 
            {
                new Triangle(5,25),
                new Triangle(18,100),
                new Rectangle(10,20),
                new Rectangle(2.5,100.8),
                new Square(100),
                new Square(1.1)
            };
            Console.WriteLine("\n____________ Surface area ".PadRight(100,'_'));
            foreach (var s in shapes)
            {
                Console.WriteLine("{0} = {1}", s, s.CalculateSurface());
            }

        }
    }
}
