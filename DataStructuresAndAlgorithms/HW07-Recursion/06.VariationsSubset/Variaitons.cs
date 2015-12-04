namespace _06.VariationsSubset
{
    using System;

    public class VariationsSubset
    {
        private static int variationSize;
        private static string[] variations;
        private static string[] set;

        public static void Main(string[] args)
        {
            variationSize = 2;

            variations = new string[variationSize];
            set = new string[3] { "test", "rock", "fun" };

            GetVariations(0, 0);
        }

        private static void GetVariations(int currentVariation, int currentCounter)
        {
            if (variations.Length == currentVariation)
            {
                PrintVariation();

                return;
            }

            for (int i = currentCounter; i < set.Length; i++)
            {
                variations[currentVariation] = set[i];
                GetVariations(currentVariation + 1, i + 1);
            }
        }

        private static void PrintVariation()
        {
            Console.WriteLine("(" + string.Join(" ", variations) + ")");
        }
    }
}
