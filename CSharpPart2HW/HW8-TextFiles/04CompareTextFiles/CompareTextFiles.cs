using System;
using System.IO;

//Problem 4. Compare text files

//    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//    Assume the files have equal number of lines.


namespace _04CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first file:");
            string firstFile = Console.ReadLine();
            string[] file1 = File.ReadAllLines(firstFile);
            Console.WriteLine("Input second file:");
            string secondFIle = Console.ReadLine();
            string[] file2 = File.ReadAllLines(secondFIle);
            int same = 0;
            int different = 0;
            for (int i = 0; i < file1.Length; i++)
            {
                if (file1[i] == file2[i])
                {
                    same++;
                }
                else
                {
                    different++;
                }
            }
            Console.WriteLine("Same: {0}", same);
            Console.WriteLine("Different: {0}", different);
        }
    }
}
