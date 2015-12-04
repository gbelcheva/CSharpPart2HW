namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        static void Main()
        {
            //C#, SQL, PHP, PHP, SQL, SQL
            var input = ReadInput();
            var occurrences = FindOddOccurrences(input);

            var oddOccurrences = occurrences
                .Where(x => x.Value % 2 != 0)
                .ToArray();

            Console.WriteLine("Odd occurrences: {0}", string.Join(", ", oddOccurrences));
        }

        private static IDictionary<string, int> FindOddOccurrences(IEnumerable<string> collection)
        {
            var result = new Dictionary<string, int>();

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

        static IEnumerable<string> ReadInput()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            return numbers;
        }
    }
}
