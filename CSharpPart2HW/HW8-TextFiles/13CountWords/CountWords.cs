using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Problem 13. Count words

//    Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//    The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//    Handle all possible exceptions in your methods.


namespace _13CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            string wordsText = "";
            string textPath = @"..\..\test.txt";
            string wordsPath = @"..\..\words.txt";
            ReadFiles(wordsPath, textPath, out wordsText, out text);

            string[] words = wordsText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordOccurence = new Dictionary<string, int>();

            foreach (string word in words)
            {
                int count = 0;
                while (text.ToString().IndexOf(word) > -1)
                {
                    count++;
                    int i = text.ToString().IndexOf(word);

                    if (text.ToString().Substring(i, word.Length) == word)
                    {
                        if (i == 0 && !char.IsLetter(text[i + word.Length]))
                        {
                            text.Remove(0, word.Length);
                        }
                        else if (i == text.Length - word.Length && !char.IsLetter(text[i - 1]))
                        {
                            text.Remove(text.Length - word.Length, word.Length);
                        }
                        else if (!char.IsLetter(text[i - 1]) && !char.IsLetter(text[i + word.Length]))
                        {
                            text.Remove(i, word.Length);
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                wordOccurence.Add(word, count);
            }
            var sortedDict = from entry in wordOccurence orderby entry.Value descending select entry;

            WriteFile(@"..\..\result.txt", sortedDict);
        }

        static void ReadFiles(string wordsFile, string textFile, out string wordsText, out StringBuilder text)
        {
            text = new StringBuilder();
            wordsText = "";
            try
            {
                text = new StringBuilder(File.ReadAllText(textFile));
                wordsText = File.ReadAllText(wordsFile);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Path null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path conatins invalid characters");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive)");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("File is read-only, or points to a directory, or you don't have the required premission, or the operation is not supported on this platform");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in invalid format");
            }
        }

        static void WriteFile(string path, IEnumerable<KeyValuePair<string, int>> sortedDict)
        {
            try
            {
                File.WriteAllLines(path,
                    sortedDict.Select(x => x.Key + " " + x.Value).ToArray());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Path null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path conatins invalid characters");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive)");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("File is read-only, or points to a directory, or you don't have the required premission, or the operation is not supported on this platform");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in invalid format");
            }
        }
    }
}
