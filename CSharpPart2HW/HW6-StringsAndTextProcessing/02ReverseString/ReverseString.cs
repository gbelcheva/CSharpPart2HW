using System;

//Problem 2. Reverse string

//    Write a program that reads a string, reverses it and prints the result at the console.

//Example:
//input 	output
//sample 	elpmas

namespace _02ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string input = Console.ReadLine();
            char[] stringChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                stringChars[i] = input[input.Length - 1 - i];
            }
            string reversed = new string(stringChars);
            Console.WriteLine("String reversed:");
            Console.WriteLine(reversed);
        }
    }
}
