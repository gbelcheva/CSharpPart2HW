using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph_Algorithmn
{
    public class dijstra
    {
        public dijstra(double[,] G, int s)
        {
            initial(0, s);
            while (queue.Count > 0)
            {
                int u = getNextVertex();
                for (int i = 0; i < s; i++)
                {
                    if (G[u, i] > 0)
                    {
                        if (dist[i] > dist[u] + G[u, i])
                        {
                            dist[i] = dist[u] + G[u, i];
                        }
                    }
                }
            }
        }

        public double[] dist { get; set; }
        int getNextVertex()
        {
            var min = double.PositiveInfinity;
            int vertex = -1;

            foreach (int val in queue)
            {
                if (dist[val] <= min)
                {
                    min = dist[val];
                    vertex = val;
                }
            }
            queue.Remove(vertex);
            return vertex;
        }
        List<int> queue = new List<int>();
        public void initial(int s, int len)
        {
            dist = new double[len];

            for (int i = 0; i < len; i++)
            {
                dist[i] = double.PositiveInfinity;
                queue.Add(i);
            }
            dist[0] = 0;
        }
    }

    public partial class Form1
    {
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

            var graph1 = new double[townsCount, townsCount];

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

            //double[,] G = new double[4, 4];
            //G[0, 1] = 3;
            //G[0, 3] = 6;
            //G[1, 3] = 1;
            //G[1, 2] = 3;
            //G[3, 2] = 1;

            var min = 1;
            for (int j = 0; j < 2; j++)
            {
                dijstra dist = new dijstra(graph1, min);
                var item = dist.dist;
                for (int i = 0; i < item.Length; i++)
                {
                    Console.WriteLine("Node " + i + " Path Distance = " + item[i]);
                }

                min = Array.IndexOf(item, item.Min());
            }


            
        }
    }
}