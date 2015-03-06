using System;

//Problem 10. Unicode characters

//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.

//Example:
//input 	output
//Hi! 	\u0048\u0069\u0021

namespace _10UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string text = Console.ReadLine();
            string[] hexVals = new string[text.Length];
            int i = 0;
            foreach (char t in text)
            {
                string hex = string.Format("{0:X}", (int)t);
                hexVals[i] = hex.PadLeft(4, '0');
                i++;
            }
            Console.WriteLine("Converted to character literals:");
            Console.WriteLine("\\u" + string.Join("\\u", hexVals));
        }
    }
}
