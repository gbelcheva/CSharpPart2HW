namespace _05.Brackets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // http://bgcoder.com/Contests/Practice/Index/123#2
            var expression = Console.ReadLine();

            int len = expression.Length;
            long[,] validExpressionsCount = new long[len + 1, len + 2];
            validExpressionsCount[0, 0] = 1;

            for (int k = 1; k <= len; k++)
            {
                if (expression[k - 1] == '(')
                {
                    validExpressionsCount[k, 0] = 0;
                }
                else
                {
                    validExpressionsCount[k, 0] = validExpressionsCount[k - 1, 1];
                }

                for (int c = 1; c <= len; c++)
                {
                    if (expression[k - 1] == '(')
                    {
                        validExpressionsCount[k, c] = validExpressionsCount[k - 1, c - 1];
                    }
                    else if (expression[k - 1] == ')')
                    {
                        validExpressionsCount[k, c] = validExpressionsCount[k - 1, c + 1];
                    }
                    else
                    {
                        validExpressionsCount[k, c] = validExpressionsCount[k - 1, c - 1] + validExpressionsCount[k - 1, c + 1];
                    }
                }
            }

            Console.WriteLine(validExpressionsCount[len, 0]);
        }
    }
}
