using System;

//Problem 5. The Biggest of 3 Numbers

//    Write a program that finds the biggest of three numbers.

//Examples:
//a 	b 	c 	biggest
//5 	2 	2 	5
//-2 	-2 	1 	1
//-2 	4 	3 	4
//0 	-2.5 	5 	5
//-0.1 	-0.5 	-1.1 	-0.1

namespace _05BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input three numbers (a, b, c): ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float biggest;
            if (a > b && a > c) biggest = a;
            else if (b > c) biggest = b;
            else biggest = c;
            Console.WriteLine("Biggest: {0}", biggest);
        }
    }
}
