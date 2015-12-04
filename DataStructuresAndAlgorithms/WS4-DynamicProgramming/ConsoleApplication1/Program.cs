using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var townsCount = int.Parse(input[0]);
            var pathsCount = int.Parse(input[1]);

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var source = int.Parse(input[0]);
            var destination = int.Parse(input[1]);

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var passTown1 = int.Parse(input[0]);
            var passTown2 = int.Parse(input[1]);

            var graph1 = new int[townsCount, townsCount];

            for (int i = 0; i < pathsCount; i++)
            {
                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                var town = int.Parse(input[0]);
                var connection = int.Parse(input[1]);
                var distance = int.Parse(input[2]);

                graph1[town - 1, connection - 1] = distance;

            }

            for (int i = 0; i < graph1.GetLength(0); i++)
            {
                for (int j = 0; j < graph1.GetLength(1); j++)
                {
                    if (graph1[i, j] == 0)
                    {
                        graph1[i, j] = -1;
                    }
                }
            }

            var d = new Dijkstra(17, graph1);

            d.Run();            
        }
    }

    class Dijkstra
    {
        private int rank = 0;
        private int[,] L;
        public int[] C;
        public int[] D;
        private int trank = 0;
        public Dijkstra(int paramRank, int[,] paramArray)
        {
            L = new int[paramRank, paramRank];
            C = new int[paramRank];
            D = new int[paramRank];
            rank = paramRank;
            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < rank; j++)
                {
                    L[i, j] = paramArray[i, j];
                }
            }

            for (int i = 0; i < rank; i++)
            {
                C[i] = i;
            }
            C[0] = -1;
            for (int i = 1; i < rank; i++)
                D[i] = L[0, i];
        }
        public void DijkstraSolving()
        {
            int minValue = Int32.MaxValue;
            int minNode = 0;
            for (int i = 0; i < rank; i++)
            {
                if (C[i] == -1)
                    continue;
                if (D[i] > 0 && D[i] < minValue)
                {
                    minValue = D[i];
                    minNode = i;
                }
            }
            C[minNode] = -1;
            for (int i = 0; i < rank; i++)
            {
                if (L[minNode, i] < 0)
                    continue;
                if (D[i] < 0)
                {
                    D[i] = minValue + L[minNode, i];
                    continue;
                }
                if ((D[minNode] + L[minNode, i]) < D[i])
                    D[i] = minValue + L[minNode, i];
            }
        }
        public void Run()
        {
            for (trank = 1; trank < rank; trank++)
            {
                DijkstraSolving();
                Console.WriteLine("iteration" + trank);
                for (int i = 0; i < rank; i++)
                    Console.Write(D[i] + " ");
                Console.WriteLine("");
                for (int i = 0; i < rank; i++)
                    Console.Write(C[i] + " ");
                Console.WriteLine("");
            }
        }
    }
}
