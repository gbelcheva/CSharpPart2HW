using System;

//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	output
//Peter	Hello, Peter!

namespace _01SayHello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            AskPrintName();
        }

        private static void AskPrintName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
