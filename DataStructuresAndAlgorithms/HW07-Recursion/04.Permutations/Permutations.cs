namespace _04.Permutations
{
    using System;

    public class Permutations
    {
        private static int totalElements;
        private static int[] permutations;

        public static void Main(string[] args)
        {
            Console.Write("n = ");
            totalElements = int.Parse(Console.ReadLine());

            permutations = new int[totalElements];
            for (int i = 0; i < permutations.Length; i++)
            {
                permutations[i] = i + 1;
            }

            GetPermutations(0);
        }

        private static void GetPermutations(int currentPermutation)
        {
            if (permutations.Length == currentPermutation)
            {
                PrintPermutation();

                return;
            }

            for (int i = currentPermutation; i < permutations.Length; i++)
            {
                if (i != currentPermutation)
                {
                    Swap(ref permutations[i], ref permutations[currentPermutation]);
                }

                GetPermutations(currentPermutation + 1);

                if (i != currentPermutation)
                {
                    Swap(ref permutations[i], ref permutations[currentPermutation]);
                }
            }
        }

        private static void PrintPermutation()
        {
            Console.WriteLine("(" + string.Join(" ", permutations) + ")");
        }

        private static void Swap(ref int v1, ref int v2)
        {
            var temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
