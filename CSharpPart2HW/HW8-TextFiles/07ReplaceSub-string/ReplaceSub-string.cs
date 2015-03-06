using System;
using System.Text;
using System.IO;

//Problem 7. Replace sub-string

//    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//    Ensure it will work with large files (e.g. 100 MB).


namespace _07ReplaceSub_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path:");
            string inputFile = Console.ReadLine();
            string[] file = File.ReadAllLines(inputFile);
            StringBuilder sb = new StringBuilder();
            foreach (string line in file)
            {
                sb.Append(line + "\r\n");
            }
            sb.Replace("start", "finish");
            File.WriteAllText(inputFile, sb.ToString());
        }
    }
}
