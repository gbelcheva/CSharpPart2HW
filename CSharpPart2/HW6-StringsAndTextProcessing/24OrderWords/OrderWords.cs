using System;
using System.Linq;

//Problem 24. Order words

//    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


namespace _24OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input list of words:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
