using System;
using System.Text;
using System.IO;

//Problem 3. Line numbers

//    Write a program that reads a text file and inserts line numbers in front of each of its lines.
//    The result should be written to another text file.


namespace _03LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file to modify:");
            string input = Console.ReadLine();
            string[] file = File.ReadAllLines(input);
            Console.WriteLine("Input output file:");
            string output = Console.ReadLine();
            string temp = "";
            StringBuilder newFile = new StringBuilder();
            for (int i = 0; i < file.Length; i++)
			{
                temp = file[i].Insert(0, (i + 1) + " ");
                newFile.Append(temp + "\r\n");
            }
            File.WriteAllText(output, newFile.ToString());
        }
    }
}
