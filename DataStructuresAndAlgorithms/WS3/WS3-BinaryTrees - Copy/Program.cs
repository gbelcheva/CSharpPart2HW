namespace BinaryTrees
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            string balls = Console.ReadLine().ToLower();
            int totalBalls = balls.Length;

            BigInteger possibleTreeConfigurations = Catalan(balls.Length);

            int[] repetitions = new int[totalBalls];
            int index = 0;
            for (int i = 0; i <= balls.Length; i++)
            {
                repetitions[index] = balls.Length;
                balls = balls.Replace(balls.Substring(0, 1), "");
                repetitions[index] -= balls.Length;
                index++;
            }

            Array.Sort(repetitions);
            Array.Reverse(repetitions);

            //totalUniquePermutations = totalElements! / (repetition1! * repetition2! * ...)
            BigInteger totalPermutations = FactorialNK(totalBalls, repetitions[0]);
            for (int i = 1; i < repetitions.Length; i++)
            {
                if (repetitions[i] <= 1)
                {
                    break;
                }

                totalPermutations = BigInteger.Divide(totalPermutations, FactorialNK(repetitions[i], 0));
            }

            Console.WriteLine(BigInteger.Multiply(totalPermutations, possibleTreeConfigurations));
        }

        private static BigInteger FactorialNK(int n, int k)
        {
            BigInteger result = 1;
            while (k < n)
            {
                result = BigInteger.Multiply(result, n--);
            }

            return result;
        }

        private static BigInteger BinomialCoeff(int n, int k)
        {
            BigInteger result = 1;
            if (k > n - k)
            {
                k = n - k;
            }

            for (int i = 0; i < k; ++i)
            {
                result = BigInteger.Multiply(result, (n - i));
                result = BigInteger.Divide(result, (i + 1));
            }

            return result;
        }

        private static BigInteger Catalan(int n)
        {
            BigInteger c = BinomialCoeff(2 * n, n);

            return BigInteger.Divide(c, (n + 1));
        }
    }
}
