using System;
using System.Text;

//Problem 5. Parse tags

//    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//    The tags cannot be nested.

//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string input = Console.ReadLine();
            int startIndex = 0;
            int endIndex = 0;
            string upperStr = "";
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < sb.Length - "</upcase>".Length; i++)
            {
                if (sb.ToString().Substring(i, "<upcase>".Length) == "<upcase>")
                {
                    startIndex = i + "<upcase>".Length;
                    i = startIndex;
                }
                if (sb.ToString().Substring(i, "</upcase>".Length) == "</upcase>")
                {
                    endIndex = i - 1;
                    upperStr = sb.ToString().Substring(startIndex, endIndex - startIndex + 1).ToUpper();
                    sb.Remove(startIndex - "<upcase>".Length, endIndex + "</upcase>".Length - startIndex + "<upcase>".Length + 1);
                    sb.Insert(startIndex - "<upcase>".Length, upperStr);
                    startIndex = 0;
                    endIndex = 0;
                    i = i - "<upcase>".Length;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
