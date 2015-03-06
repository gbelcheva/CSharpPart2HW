using System;
using System.Text;


//Problem 2. Compare arrays

//    Write a program that reads two integer arrays from the console and compares them element by element.

namespace _02CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integer arrays, each with their elements on a single line, separated with space.\n");
IncorrectData:
            string[][] numsString = new string[2][];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Input array{0}:", i + 1);
                numsString[i] = Console.ReadLine().Split(new Char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            }
            if (numsString[0].Length != numsString[1].Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The arrays are NOT the same.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            int tempInt;
            int sizeArrays = numsString[0].Length;
            int[,] numsArray = new int[2, sizeArrays];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < sizeArrays; j++)
                {
                    if (!int.TryParse(numsString[i][j], out tempInt))
                    {
                        Console.WriteLine("Incorrect input. Try again.");
                        //one of the very few times (if not the only one) when goto works well - to exit nested loops
                        goto IncorrectData; 
                    }
                    numsArray[i, j] = int.Parse(numsString[i][j]);
                }
            }
            bool same = true;
            for (int j = 0; j < sizeArrays; j++)
            {
                if (numsArray[0, j] != numsArray[1, j])
                {
                    same = false;
                    break;
                }
            }
            if (same)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The arrays are the same!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The arrays are NOT the same.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
