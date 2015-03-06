using System;
using System.Text;
using System.IO;

//Problem 10. Extract text from XML

//    Write a program that extracts from given XML file all the text without the tags.

//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

namespace _10ExtractTextFromXML
{
    class ExtractTextFromXML
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
            int startIndex = 0;
            int endIndex = 0;
            while (sb.ToString().IndexOf("<") > -1)
            {
                startIndex = sb.ToString().IndexOf("<");
                endIndex = sb.ToString().IndexOf(">");
                sb.Remove(startIndex, endIndex - startIndex + 1);
            }
            File.WriteAllText(inputFile, sb.ToString());
        }
    }
}
