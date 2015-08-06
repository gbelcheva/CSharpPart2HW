namespace Task4_Compare_sort_algorithms
{
    using System;

    public class CompareSortAlgorithms
    {
        public static void Main(string[] args)
        {
            var performanceComparer = new PerformanceComparer();

            Console.WriteLine("Iterations: " + PerformanceComparer.IterationsCount);
            Console.WriteLine();

            foreach (Algorithms algorithm in Enum.GetValues(typeof(Algorithms)))
            {
                foreach (Values value in Enum.GetValues(typeof(Values)))
                {
                    foreach (Cases c in Enum.GetValues(typeof(Cases)))
                    {
                        Console.WriteLine("{0} {1} {2} : {3}", algorithm, value, c, performanceComparer.TimeExecution(algorithm, value, c));
                    }
                }
            }
        }
    }
}
