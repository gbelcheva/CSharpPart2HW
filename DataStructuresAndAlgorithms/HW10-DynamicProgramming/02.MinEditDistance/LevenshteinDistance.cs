namespace _02.MinEditDistance
{
    using System;

    public class LevenshteinDistance
    {
        private const double InsertCost = 0.8;
        private const double DeleteCost = 0.9;
        private const double ReplaceCost = 1.0;

        public static double Compute(string string1, string string2)
        {
            var distances = new double[string1.Length + 1, string2.Length + 1];
            for (int i = 0; i <= string1.Length; i++)
            {
                distances[i, 0] = i * DeleteCost;
            }

            for (int j = 0; j <= string2.Length; j++)
            {
                distances[0, j] = j * DeleteCost;
            }

            for (int i = 1; i <= string1.Length; i++)
            {
                for (int j = 1; j <= string2.Length; j++)
                {
                    if (string1[i - 1] == string2[j - 1])
                    {
                        distances[i, j] = distances[i - 1, j - 1];
                    }
                    else
                    {
                        distances[i, j] = Math.Min(Math.Min(distances[i - 1, j - 1] + ReplaceCost,
                                                            distances[i - 1, j] + InsertCost), 
                                                   distances[i, j - 1] + InsertCost);
                    }
                }
            }

            return distances[string1.Length,string2.Length];
        }
    }
}