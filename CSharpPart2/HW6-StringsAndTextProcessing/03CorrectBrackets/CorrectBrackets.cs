using System;

//Problem 3. Correct brackets

//    Write a program to check if in a given expression the brackets are put correctly.

//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))

namespace _03CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input expression:");
            string input = Console.ReadLine();
            bool bracketsCorrect = false;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (count < 0)
                {
                    Console.WriteLine("Are brackets put correctly?\n{0}", bracketsCorrect);
                    return;
                }
                if (input[i] == '(')
                {
                    count++;
                }
                if (input[i] == ')')
                {
                    count--;
                }
            }
            if (count == 0)
            {
                bracketsCorrect = true;
            }
            Console.WriteLine("Are brackets put correctly?\n{0}", bracketsCorrect);
        }
    }
}
