using System;
using System.Collections.Generic;
using System.Text;

//Problem 8. Extract sentences

//    Write a program that extracts from a given text all sentences containing given word.

//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

namespace _08ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string[] sentences = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Input word to search:");
            string word = Console.ReadLine().ToLower();
            List<string> matchedSentences = new List<string>();
            string tempSentence = "";
            foreach (string sentence in sentences)
            {
                    tempSentence = sentence.ToLower();
                    if (tempSentence.IndexOf(word) > -1)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < tempSentence.Length; i++)
                        {
                            if ( !char.IsLetter(tempSentence[i]))
                            {
                                if (sb.ToString() == word)
                                {
                                    matchedSentences.Add((sentence + ".").Trim());
                                    break;
                                }
                                sb.Clear();
                                continue;
                            }
                            sb.Append(tempSentence[i]);
                            if (i == tempSentence.Length - 1)
                            {
                                if (sb.ToString() == word)
                                {
                                    matchedSentences.Add((sentence + ".").Trim());
                                }
                            }
                        }
                        
                    }
                    
            }
            Console.WriteLine("The word \"{0}\" is found in:", word);
            Console.WriteLine(string.Join(" ", matchedSentences));
        }
    }
}
