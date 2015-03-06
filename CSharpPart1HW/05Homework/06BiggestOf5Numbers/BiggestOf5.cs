using System;

//Problem 6. The Biggest of Five Numbers

//    Write a program that finds the biggest of five numbers by using only five if statements.

//Examples:
//a 	b 	c 	d 	e 	biggest
//5 	2 	2 	4 	1 	5
//-2 	-22 	1 	0 	0 	1
//-2 	4 	3 	2 	0 	4
//0 	-2.5 	0 	5 	5 	5
//-3 	-0.5 	-1.1 	-2 	-0.1 	-0.1

namespace _06BiggestOf5Numbers
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input five numbers: ");
            float current;
            float biggest = float.MinValue;
            for (int i = 0; i < 5; i++)
            {
                current = float.Parse(Console.ReadLine());
                if (current > biggest)
                {
                    biggest = current;
                }
            }
            Console.WriteLine("Biggest: {0}", biggest);
        }
    }
}
