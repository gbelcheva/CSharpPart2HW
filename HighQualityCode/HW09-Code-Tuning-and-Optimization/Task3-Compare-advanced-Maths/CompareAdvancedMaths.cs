namespace Task3_Compare_advanced_Maths
{
    using System;

    public class CompareAdvancedMaths
    {
        public static void Main(string[] args)
        {
            var performanceComparer = new PerformanceComparer();

            Console.WriteLine("Iterations: " + PerformanceComparer.IterationsCount);
            Console.WriteLine();

            foreach (Operations operation in Enum.GetValues(typeof(Operations)))
            {
                foreach (Values value in Enum.GetValues(typeof(Values)))
                {
                    Console.WriteLine("{0} {1} : {2}", operation, value, performanceComparer.TimeExecution(operation, value));
                }
            }
        }
    }
}
