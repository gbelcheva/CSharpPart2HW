using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LongestAreaArray
{
    class LongestAreaArray
    {
        static void Main(string[] args)
        {
            Console.Write("Input length n and n strings: ");
            int n = int.Parse(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++) stringArray[i] = Console.ReadLine();
            List<string> equalStrings = new List<string>();
            List<string> longestEqualStrings = EqualStrings(stringArray[0], stringArray);
            for (int i = 1; i < n; i++)
            {
                equalStrings = EqualStrings(stringArray[i], stringArray);
                longestEqualStrings = (equalStrings.Count > longestEqualStrings.Count) ? equalStrings : longestEqualStrings;
            }
            Console.WriteLine();
            Console.WriteLine(longestEqualStrings.Count);
            for (int i = 0; i < longestEqualStrings.Count; i++)
            {
                Console.WriteLine(longestEqualStrings[i]);
            }
        }

        static List<string> EqualStrings(string checkString, string[] strings)
        {
            List<string> equalStrings = new List<string>();
            for (int j = 0; j < strings.Length; j++)
            {
                if (checkString == strings[j])
                {
                    equalStrings.Add(strings[j]);
                }
            }
            return equalStrings;
        }
    }
}
