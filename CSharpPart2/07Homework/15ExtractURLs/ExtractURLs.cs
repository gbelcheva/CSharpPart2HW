using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _15ExtractURLs
{
    class ExtractURLs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC when finished enetering data.\n");
            List<string> textLines = new List<string>();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                textLines.Add(Console.ReadLine());
            }
            string[] punctuation = { "?", "!", ".", "-"};
            for (int i = 0; i < textLines.Count; i++)
            {
                string[] dataPieces = textLines[i].Split(' ');
                for (int j = 0; j < dataPieces.Length; j++)
                {
                    if (dataPieces[j].Length < 7) continue;
                    else if (dataPieces[j].Substring(0, 4) == "www." || dataPieces[j].Substring(0, 7) == "http://")
                    {
                        dataPieces[j] = Regex.Replace(dataPieces[j], @"[\p{P}-[-_.~%=$?!//:]]", string.Empty);
                        bool done = false;
                        while (!done)
                        {
                            for (int k = 0; k < punctuation.Length; k++)
                            {
                                if (dataPieces[j].Substring(dataPieces[j].Length - 2, 1) == punctuation[k])
                                {
                                    dataPieces[j] = dataPieces[j].Substring(0, dataPieces[j].Length - 2);
                                }
                                else
                                {
                                    done = true;
                                }
                            }
                        }
                        Console.WriteLine(dataPieces[j]);
                    }
                }
            }
        }
    }
}
