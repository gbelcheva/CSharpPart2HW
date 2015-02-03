using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _14LongestWord
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC when finished enetering data.\n");
            List<string> textLines = new List<string>();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                textLines.Add(Regex.Replace(Console.ReadLine(), @"[^\w\s]", string.Empty));
            }
            string max = "";
            for (int i = 0; i < textLines.Count; i++)
            {
                string[] dataPieces = textLines[i].Split(' ');
                for (int j = 0; j < dataPieces.Length; j++)
                {
                    max = (dataPieces[j].Length > max.Length) ? dataPieces[j] : max;
                }
            }
            Console.WriteLine(max);
        }
    }
}
