using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//Problem 11. Prefix "test"

//    Write a program that deletes from a text file all words that start with the prefix test.
//    Words contain only the symbols 0…9, a…z, A…Z, _.


namespace _11PrefixTest
{
    class PrefixTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path:");
            string inputFile = Console.ReadLine();
            string[] file = File.ReadAllLines(inputFile);
            StringBuilder text = new StringBuilder();
            foreach (string line in file)
            {
                text.Append(line + "\r\n");
            }
            List<string> words = new List<string>();
            StringBuilder w = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                while (char.IsLetter(text[i]) || char.IsDigit(text[i]) || text[i] == '_')
                {
                    w.Append(text[i]);
                    i++;
                }
                if (w.Length > 0)
                {
                    words.Add(w.ToString());
                }
                w.Clear();
            }
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > "test".Length)
                {
                    if (words[i].ToLower().Substring(0, "test".Length) == "test")
                    {
                        text.Remove(text.ToString().IndexOf(words[i]), "test".Length);
                    }
                }
                
            }
            File.WriteAllText(inputFile, text.ToString());
        }
    }
}
