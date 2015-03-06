using System;
using System.Text;

//Problem 13. Reverse sentence

//    Write a program that reverses the words in given sentence.

//Example:
//input 	output
//C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

namespace _13ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input sentence:");
            string sentence = Console.ReadLine();
            char[] chs = { ' ', ',', '!', '?', '.', ';', ':' };
            string[] words = sentence.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            StringBuilder sb = new StringBuilder();
            string[] separators = sentence.Split(words, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i]);
                if (i < separators.Length)
                {
                    sb.Append(separators[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
