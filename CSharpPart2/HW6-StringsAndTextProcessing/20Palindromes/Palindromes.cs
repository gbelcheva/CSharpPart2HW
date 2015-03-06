using System;
using System.Collections.Generic;
using System.Linq;

//Problem 20. Palindromes

//    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.


namespace _20Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string sentence = Console.ReadLine();
            char[] chs = { ' ', ',', '!', '?', '.', ';', ':' };
            string[] words = sentence.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (string word in words)
            {
                if (CheckPalindrome(word) && word.Length > 1)
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine("\nFound palindromes:\n");
            Console.WriteLine(string.Join("\n", palindromes));
        }

        private static bool CheckPalindrome(string word)
        {
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return isPalindrome = false;
                }
            }
            return isPalindrome;
        }
    }
}
