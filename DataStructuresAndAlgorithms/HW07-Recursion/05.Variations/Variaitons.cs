namespace _05.Variations
{
    using System;

    public class Variations
    {
        private static int variationSize;
        private static int totalElements;
        private static int[] variations;
        private static int[] set;

        public static void Main(string[] args)
        {
            Console.Write("n = ");
            totalElements = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            variationSize = int.Parse(Console.ReadLine());

            variations = new int[variationSize];
            set = new int[totalElements];
            for (int i = 0; i < totalElements; i++)
            {
                set[i] = i;
            }

            GetVariations(0);
        }

        private static void GetVariations(int currentVariation)
        {
            if (variations.Length == currentVariation)
            {
                PrintVariation();

                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                variations[currentVariation] = set[i];
                GetVariations(currentVariation + 1);
            }
        }

        private static void PrintVariation()
        {
            Console.WriteLine("(" + string.Join(" ", variations) + ")");
        }
    }
}
