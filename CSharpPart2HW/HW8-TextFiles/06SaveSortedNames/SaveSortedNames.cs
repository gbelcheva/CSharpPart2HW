using System;
using System.Text;
using System.IO;

//Problem 6. Save sorted names

//    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

//Example:
//input.txt 	output.txt
//Ivan
//Peter
//Maria
//George 	
//George
//Ivan
//Maria
//Peter

namespace _06SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path:");
            string inputFile = Console.ReadLine();
            string[] file = File.ReadAllLines(inputFile);
            Array.Sort(file);
            StringBuilder sb = new StringBuilder();
            foreach (string line in file)
            {
                sb.Append(line + "\r\n");
            }
            Console.WriteLine("Input output file:");
            string outputFile = Console.ReadLine();
            File.WriteAllText(outputFile, sb.ToString());
        }
    }
}
