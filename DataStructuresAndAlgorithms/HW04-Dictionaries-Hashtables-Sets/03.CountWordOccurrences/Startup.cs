namespace _03.CountWordOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private static readonly char[] punctuation = new char[] { '.', ',', '!', ' ', '/', '-', ':', ';', '?', '"', '\'', '&', '–' };

        static void Main()
        {
            var input = File.ReadAllText("../../Joke.txt")
                 .Split(punctuation, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x.ToLower())
                 .ToArray();

            var wordOccurrences = FindWordOccurrences(input).OrderBy(x => x.Value); ;
            
            foreach (var occurrence in wordOccurrences)
            {
                Console.WriteLine("{0} -> {1} time(s)", occurrence.Key, occurrence.Value);
            }
        }


        private static IDictionary<string, int> FindWordOccurrences(IEnumerable<string> collection)
        {
            var result = new SortedDictionary<string, int>();

            foreach (var item in collection)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }

                result[item]++;
            }

            return result;
        }
    }
}
