namespace DijkstraWithoutQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DijkstraWithoutQueue
    {
        private static int[] Distance;
        private static int?[] Previous;
        private static readonly HashSet<int> SetOfNodes = new HashSet<int>();

        public static void Dijkstra(int[,] graph, int source)
        {
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                Distance[i] = int.MaxValue;
                Previous[i] = null;
                SetOfNodes.Add(i);
            }

            Distance[source] = 0;

            while (SetOfNodes.Count != 0)
            {
                int minNode = int.MaxValue;

                foreach (var node in SetOfNodes)
                {
                    if (minNode > Distance[node])
                    {
                        minNode = node;
                    }
                }

                SetOfNodes.Remove(minNode);

                if (minNode == int.MaxValue)
                {
                    break;
                }

                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[minNode, i] > 0)
                    {
                        int potentialDistance = Distance[minNode] + graph[minNode, i];
                        if (potentialDistance < Distance[i])
                        {
                            Distance[i] = potentialDistance;
                            Previous[i] = minNode;
                        }
                    }
                }
            }
        }

        public static void Main()
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

            var graph = new[,]
                               {
                                   { 0, 23, 0, 0, 0, 0, 0, 8, 0, 0 },
                                   { 23, 0, 0, 3, 0, 0, 34, 0, 0, 0 },
                                   { 0, 0, 0, 6, 0, 0, 0, 25, 0, 7 },
                                   { 0, 3, 6, 0, 0, 0, 0, 0, 0, 0 },
                                   { 0, 0, 0, 0, 0, 10, 0, 0, 0, 0 },
                                   { 0, 0, 0, 0, 10, 0, 0, 0, 0, 0 },
                                   { 0, 34, 0, 0, 0, 0, 0, 0, 0, 0 },
                                   { 8, 0, 25, 0, 0, 0, 0, 0, 0, 30 },
                                   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                   { 0, 0, 7, 0, 0, 0, 0, 30, 0, 0 }
                               };


            Distance = new int[townsCount];
                Previous = new int?[townsCount];

                Dijkstra(graph1, 0);

                //Console.WriteLine("====================== " + j);


                Console.WriteLine(Distance[0]);
            Console.WriteLine(string.Join(" ", Distance));

                //Console.Write("Distance from 1 to {0}: ", i + 1);
                //if (Distance[i] == int.MaxValue)
                //{
                //    Console.WriteLine("No path.");
                //}
                //else
                //{
                //    Console.Write("Path: ");

                //    int? indexer = i;
                //    while (indexer != 0)
                //    {
                //        Console.Write(indexer + 1 + " ");
                //        //indexer = Previous[indexer.Value];
                //    }

                //    Console.Write("1 ");

                //    Console.WriteLine("Distance: " + Distance[i]);
                //}




            //var distancePassTown1 = Distance[passTown1];
            //var distancePassTown2 = Distance[passTown2];

            //Console.WriteLine("{0}   {1}", distancePassTown1, distancePassTown2);

            //var minDistance = 0;
            //if (distancePassTown1 < distancePassTown2)
            //{
            //    minDistance = distancePassTown1;
            //}
            //else
            //{
            //    minDistance = distancePassTown2;
            //}


            //Dijkstra(graph1, passTown1 - 1);

            //minDistance += Distance[passTown2];

            //Dijkstra(graph1, passTown2 - 1);

            //minDistance += Distance[destination];

            //Console.WriteLine(minDistance);




        }
    }
}

