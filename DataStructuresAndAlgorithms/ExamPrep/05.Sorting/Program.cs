using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(BFS(numbers, k));
        }

        private static int BFS(int[] numbers, int k)
        {
            // key - permutation hash code
            // value - min path to key
            var visited = new Dictionary<int, int>();

            var queue = new Queue<int[]>();
            queue.Enqueue(numbers);
            visited.Add(GetHashCode(numbers), 0);

            while (queue.Count > 0)
            {
                var currentPermutation = queue.Dequeue();
                var currentPath = visited[GetHashCode(currentPermutation)];
                if (IsSorted(currentPermutation))
                {
                    return currentPath;
                }

                for (int i = 0; i <= numbers.Length - k; i++)
                { 
                    var child = currentPermutation.Clone() as int[];
                    Array.Reverse(child, i, k);

                    if (!visited.ContainsKey(GetHashCode(child)))
                    {
                        visited.Add(GetHashCode(child), currentPath + 1);
                        queue.Enqueue(child);
                    }
                }
            }

            return -1;
        }

        private static int GetHashCode(int[] values)
        {
            int hash = 0;

            foreach (var val in values)
            {
                hash *= 8;
                hash += val;
            }

            return hash;
        } 

        private static bool IsSorted(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
