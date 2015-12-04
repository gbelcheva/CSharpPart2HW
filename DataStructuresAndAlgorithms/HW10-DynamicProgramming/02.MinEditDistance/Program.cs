namespace _02.MinEditDistance
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(LevenshteinDistance.Compute("developer", "enveloped"));
        }
    }
}
