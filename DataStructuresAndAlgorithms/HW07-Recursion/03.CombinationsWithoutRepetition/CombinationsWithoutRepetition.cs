namespace CombinationsWithoutRepetition
{
    using System;

    public class CombinationsWithoutRepetition
    {
        private static int combinationSize;
        private static int totalElements;
        private static int[] combination;
        private static int total;

        public static void Main(string[] args)
        {
            Console.Write("n = ");
            totalElements = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            combinationSize = int.Parse(Console.ReadLine());

            combination = new int[combinationSize];

            GetCombinations(0, 0);
        }

        private static void GetCombinations(int currentCombination, int currentCounter)
        {
            if (currentCombination == combinationSize)
            {
                PrintCombination();

                return;
            }

            for (int counter = currentCounter; counter < totalElements; counter++)
            {
                combination[currentCombination] = counter;
                GetCombinations(currentCombination + 1, ++currentCounter);
            }
        }

        private static void PrintCombination()
        {
            Console.WriteLine("(" + string.Join(" ", combination) + ")");
        }
    }
}
