using System;
using System.Linq;
using System.Text;

//Problem 9. Forbidden words

//    We are given a string containing a list of forbidden words and a text containing some of these words.
//    Write a program that replaces the forbidden words with asterisks.

//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace _09ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Input forbiddent words list on a single line:");
            string[] fWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string tmpWord = "";
            string tmpText = text.ToString().ToLower();
            foreach (string word in fWords)
            {
                tmpWord = word.ToLower();
                string asterisks = new string('*', tmpWord.Length);
                if (tmpText.IndexOf(tmpWord) > -1)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < tmpText.Length; i++)
                    {
                        if (!char.IsLetter(tmpText[i]))
                        {
                            if (sb.ToString() == tmpWord)
                            {
                                text.Remove(i - tmpWord.Length, tmpWord.Length);
                                text.Insert(i - tmpWord.Length, asterisks);
                            }
                            sb.Clear();
                            continue;
                        }
                        sb.Append(tmpText[i]);
                        if (i == tmpText.Length - 1)
                        {
                            if (sb.ToString() == tmpWord)
                            {
                                text.Remove(i - tmpWord.Length, tmpWord.Length);
                                text.Insert(i - tmpWord.Length, asterisks);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("The modified text is:");
            Console.WriteLine(text);
        }
    }
}
