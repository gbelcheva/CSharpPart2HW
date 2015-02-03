using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _16CountWord
{
    class CountWord
    {
        static void Main(string[] args)
        {
            Console.Write("Input word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Press ESC when finished enetering text.\n");
            List<string> textLines = new List<string>();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                textLines.Add(Regex.Replace(Console.ReadLine(), @"[^\w\s]", " "));
            }
            int counter = 0;
            for (int i = 0; i < textLines.Count; i++)
            {
                string[] dataPieces = textLines[i].Split(' ');
                for (int j = 0; j < dataPieces.Length; j++)
                {
                    if (dataPieces[j].Length >= word.Length)
                    {
                        if (dataPieces[j].ToLower() == word.ToLower())
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
