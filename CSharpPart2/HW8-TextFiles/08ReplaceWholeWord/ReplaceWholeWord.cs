using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//Problem 8. Replace whole word

//    Modify the solution of the previous problem to replace only whole words (not strings).


namespace _08ReplaceWholeWord
{
    class ReplaceWholeWord
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
            char[] chars = { '.', '!', '?', '(', ')', '[', ']', '{', '}', ';', '\'', '\"' , ':', '"', ' ', ','};
            List<string> wordsOld = new List<string>();
            List<string> wordsNew = new List<string>();
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    wordsOld.Add(chars[i] + "start" + chars[j]);
                    wordsNew.Add(chars[i] + "finish" + chars[j]);
                    sb.Replace(wordsOld[count].ToString(), wordsNew[count].ToString());
                    count++;
                }
            }
            if (sb.ToString().Substring(0, "start".Length) == "start")
            {
                sb.Remove(0, "start".Length);
                sb.Insert(0, "finish");
            }
            File.WriteAllText(inputFile, sb.ToString());
        }
    }
}
