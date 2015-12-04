namespace P01_TowerOfHanoi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TowerOfHanoi
    {
        private static int steps = 0;

        static void Main(string[] args)
        {
            int numberOfDiscs;
            Console.Write("Enter number of discs: ");
            int.TryParse(Console.ReadLine(), out numberOfDiscs);

            var range = Enumerable.Range(1, numberOfDiscs);
            Stack<int> source = new Stack<int>(range.Reverse());
            Stack<int> destination = new Stack<int>();
            Stack<int> spare = new Stack<int>();

            PrintRods(source, destination, spare);
            MoveDiscs(numberOfDiscs, source, destination, spare);
            Console.WriteLine("Steps = {0} = 2^{1} - 1", steps, numberOfDiscs);
        }

        private static void MoveDiscs(int bottomDisc, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisc == 1)
            {
                destination.Push(source.Pop());
                steps++;
                PrintRods(source, destination, spare);
            }
            else if (bottomDisc > 1)
            {
                MoveDiscs(bottomDisc - 1, source, spare, destination);
                destination.Push(source.Pop());
                PrintRods(source, destination, spare);
                steps++;
                MoveDiscs(bottomDisc - 1, spare, destination, source);
            }
        }

        private static void PrintRods(Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            Console.WriteLine("Source: {0}", string.Join(" ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(" ", destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(" ", spare.Reverse()));
            Console.WriteLine();
        }


    }
}
