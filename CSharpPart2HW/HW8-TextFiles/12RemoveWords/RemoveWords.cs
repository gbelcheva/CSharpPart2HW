using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Problem 12. Remove words

//    Write a program that removes from a text file all words listed in given another text file.
//    Handle all possible exceptions in your methods.



namespace _12RemoveWords
{
    class RemoveWords
    {
        static void Main(string[] args)
        {
            
            StringBuilder text = new StringBuilder();
            string wordsText = "";
            string textPath = @"..\..\text.txt";
            string wordsPath = @"..\..\words.txt";
            ReadFiles(wordsPath, textPath, out wordsText, out text);

            string[] words = wordsText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                while (text.ToString().IndexOf(word) > -1)
                {
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
            }
            WriteFile(@"..\..\text.txt", text);
            Console.WriteLine(text.ToString());
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

        static void WriteFile(string path, StringBuilder sb)
        {
            try
            {
                File.WriteAllText(path, sb.ToString());
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
