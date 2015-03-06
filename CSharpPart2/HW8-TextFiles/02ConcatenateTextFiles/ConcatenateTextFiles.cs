using System;
using System.IO;

//Problem 2. Concatenate text files

//    Write a program that concatenates two text files into another text file.


namespace _02ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of files to concatenate:");
            int n = int.Parse(Console.ReadLine());
            string[] fileAry = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input file path:");
                fileAry[i] = Console.ReadLine();
            }
            Console.WriteLine("Input destination file path and name:");
            string destFile = Console.ReadLine();
            using (var destStream = File.Create(destFile))
            {
                foreach (string filePath in fileAry)
                {
                    using (var sourceStream = File.OpenRead(filePath))
                        sourceStream.CopyTo(destStream);
                    Console.WriteLine("File Processed: {0}", filePath);
                }
            }
        }
    }
}
