using System;
using System.Collections.Generic;
using System.Linq;

//Problem 22. Words count

//    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.


namespace _22WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");

            string text = Console.ReadLine().ToLower();
            char[] chs = { ' ', ',', '!', '?', '.', ';', ':' };
            List<string> words = text.Split(chs, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            while (words.Count > 0)
            {
                int count = 1;
                for (int i = 1; i < words.Count; i++)
                {
                    if (words[0] == words[i])
                    {
                        count++;
                        words.RemoveAt(i);
                        i--;
                    }
                }
                occurences.Add(words[0], count);
                words.RemoveAt(0);
            }

            Console.WriteLine("\nAll different words and their occurrences:\n");
            foreach (KeyValuePair<string, int> occur in occurences)
            {
                Console.WriteLine(occur.Key + " - " + occur.Value);
            }
        }
    }
}
