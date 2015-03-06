using System;
using System.Collections.Generic;
using System.Text;

//Problem 21. Letters count

//    Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

namespace _21LettersCount
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            StringBuilder text = new StringBuilder(Console.ReadLine().ToLower());
            Dictionary<char, int> occurences = new Dictionary<char, int>();
            while (text.Length > 0)
            {
                int counter = 1;
                if (!char.IsLetter(text[0]))
                {
                    text.Remove(0, 1);
                    continue;
                }
                for (int i = 1; i < text.Length; i++)
                {
                    if (text[0] == text[i])
                    {
                        text.Remove(i, 1);
                        counter++;
                        i--;
                    }
                }
                occurences.Add(text[0], counter);
                text.Remove(0, 1);
            }

            Console.WriteLine("\nAll different letter and their occurrences:\n");
            foreach (KeyValuePair<char,int> occur in occurences)
            {
                Console.WriteLine(occur.Key + " - " + occur.Value);
            }
        }
    }
}
