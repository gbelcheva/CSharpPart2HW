namespace _04.SuperSum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // http://bgcoder.com/Contests/Practice/Index/123#1

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var k = input[0];
            var n = input[1];

            var superSum = new int[k + 1, n + 1];

            for (int i = 0; i <= n; i++)
            {
                superSum[0, i] = i;
            }

            for (int row = 1; row <= k; row++)
            {
                for (int col = 0; col <= n; col++)
                {
                    for (int j = 0; j <= col; j++)
                    {
                        superSum[row, col] += superSum[row - 1, j];
                    }
                }
            }

            Console.WriteLine(superSum[k, n]);
        }
    }
}
