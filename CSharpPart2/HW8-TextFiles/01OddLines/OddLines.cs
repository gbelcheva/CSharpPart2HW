using System;
using System.IO;

//Problem 1. Odd lines

//    Write a program that reads a text file and prints on the console its odd lines.


namespace _01OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path:");
            string path = Console.ReadLine();
            int counter = 0;
            string line;
            System.IO.StreamReader file =
               new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }

            file.Close();
        }
    }
}
