namespace _03.Tribonacci
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // http://bgcoder.com/Contests/Practice/Index/123#0

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            Console.WriteLine(NthTribonacci(input[0], input[1], input[2], input[3]));
        }

        private static long NthTribonacci(long tribonacci1, long tribonacci2, long tribonacci3, long nTribonacci)
        {
            long result = 0;

            if (nTribonacci == 1)
            {
                result = tribonacci1;
            }
            else if (nTribonacci == 2)
            {
                result = tribonacci2;
            }
            else if (nTribonacci == 3)
            {
                result = tribonacci3;
            }

            while (nTribonacci > 3)
            {
                result = tribonacci1 + tribonacci2 + tribonacci3;
                tribonacci1 = tribonacci2;
                tribonacci2 = tribonacci3;
                tribonacci3 = result;
                nTribonacci--;
            }

            return result;
        }
    }
}
