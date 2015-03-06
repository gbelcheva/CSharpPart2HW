using System;
using System.Text;
using System.IO;

//Problem 9. Delete odd lines

//    Write a program that deletes from given text file all odd lines.
//    The result should be in the same file.

namespace _09DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path:");
            string inputFile = Console.ReadLine();
            string[] file = File.ReadAllLines(inputFile);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sb.Append(file[i] + "\r\n");
                }
            }
            sb.Replace("start", "finish");
            File.WriteAllText(inputFile, sb.ToString());
        }
    }
}
