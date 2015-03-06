using System;

//Problem 4. Sub-string in text

//    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

namespace _04Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string input = Console.ReadLine();
            Console.WriteLine("Input string to search:");
            string sub = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length - sub.Length; i++)
			{
                if (input.Substring(i, sub.Length) == sub)
                {
                    count++;
                }
			}
            Console.WriteLine("The string appears {0} times.", count);
        }
    }
}
