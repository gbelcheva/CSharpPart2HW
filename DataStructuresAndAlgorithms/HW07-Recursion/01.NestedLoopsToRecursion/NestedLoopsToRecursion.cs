namespace NestedLoopsToRecursion
{
    using System;

    public class NestedLoopsToRecursion
    {
        private static int numberOfLoops;
        private static int loopsCounter;
        private static int[] loops;

        public static void Main(string[] args)
        {
            Console.Write("n = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            loopsCounter = numberOfLoops;

            loops = new int[numberOfLoops];

            NestedLoops(0);
        }

        private static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintNestedLoops();

                return;
            }

            for (int counter = 1; counter <= loopsCounter; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }

        private static void PrintNestedLoops()
        {
            Console.WriteLine(string.Join(" ", loops));
        }
    }
}
