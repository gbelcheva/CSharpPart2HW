using System;
using System.Text;

//Problem 23. Series of letters

//    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

//Example:
//input 	output
//aaaaabbbbbcdddeeeedssaa 	abcdedsa

namespace _23SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            StringBuilder text = new StringBuilder(Console.ReadLine().ToLower());

            for (int i = 0; i < text.Length - 1; i++)
            {
                int j = i + 1;
                while (text[i] == text[j])
                {
                    text.Remove(j , 1);
                    if (j > text.Length - 1)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(text.ToString());
        }
    }
}
