using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var townsCount = int.Parse(input[0]);
            var pathsCount = int.Parse(input[1]);

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var source = int.Parse(input[0]);
            var destination =  int.Parse(input[1]);

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var passTown1 = int.Parse(input[0]);
            var passTown2 = int.Parse(input[1]);

            var graph = new double[townsCount + 1, townsCount + 1];

            for (int i = 0; i < pathsCount; i++)
            {
                var edges = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

                graph[edges[0], edges[1]] = edges[2];
                graph[edges[1], edges[0]] = edges[2];
            }


            double totalDistance = 0;

            var d = new Dijkstra(graph, source);

            var distances = d.dist;
            var passDistance1 = distances[passTown1];
            var passDistance2 = distances[passTown2];

            if (passDistance1 <= passDistance2)
            {
                totalDistance += passDistance1;
                distances = new Dijkstra(graph, passTown1).dist;
                passDistance2 = distances[passTown2];
                totalDistance += passDistance2;

                distances = new Dijkstra(graph, passTown2).dist;
            }
            else
            {
                totalDistance += passDistance2;
                distances = new Dijkstra(graph, passTown2).dist;
                passDistance2 = distances[passTown1];
                totalDistance += passDistance2;

                distances = new Dijkstra(graph, passTown1).dist;
            }

            passDistance2 = distances[destination];
            totalDistance += passDistance2;

            Console.WriteLine(totalDistance);

            //var array = new double[,]
            //{
            //    { 0, 2, 5, 0, 0},
            //    { 0, 0, 0, 4, 0},
            //    { 0, 6, 0, 0, 8},
            //    { 0, 0, 0, 0, 9},
            //    { 0, 0, 2, 0, 0}
            //};


            //Console.WriteLine(d.dist[2]);

            //Console.WriteLine(string.Join(" -> ", d.path));
        }
    }

    public class Edge
    {
        public int from { get; private set; }
        public int to { get; private set; }
        public Double weight { get; private set; }

        public Edge(int from, int to, Double weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }
    }

    public class Vertex
    {
        public int ident { get; private set; }
        public int dist { get; set; }

        public Vertex(int ident)
        {
            this.ident = ident;
        }
    }

    public class Dijkstra
    {
        /* Takes adjacency matrix in the following format, for a directed graph (2-D array)
         * Ex. node 1 to 3 is accessible at a cost of 4
         *        0  1  2  3  4 
         *   0  { 0, 2, 5, 0, 0},
         *   1  { 0, 0, 0, 4, 0},
         *   2  { 0, 6, 0, 0, 8},
         *   3  { 0, 0, 0, 0, 9},
         *   4  { 0, 0, 0, 0, 0}
         */

        /* Resulting arrays with distances to nodes and how to get there */
        public double[] dist { get; private set; }
        public int[] path { get; private set; }

        /* Holds queue for the nodes to be evaluated */
        private List<int> queue = new List<int>();

        /* Sets up initial settings */
        private void Initialize(int s, int len)
        {
            dist = new double[len];
            path = new int[len];

            /* Set distance to all nodes to infinity - alternatively use Int.MaxValue for use of Int type instead */
            for (int i = 0; i < len; i++)
            {
                dist[i] = Double.PositiveInfinity;

                queue.Add(i);
            }

            /* Set distance to 0 for starting point and the previous node to null (-1) */
            dist[s] = 0;
            path[s] = -1;
        }

        /* Retrives next node to evaluate from the queue */
        private int GetNextVertex()
        {
            double min = Double.PositiveInfinity;
            int Vertex = -1;

            /* Search through queue to find the next node having the smallest distance */
            foreach (int j in queue)
            {
                if (dist[j] <= min)
                {
                    min = dist[j];
                    Vertex = j;
                }
            }

            queue.Remove(Vertex);

            return Vertex;

        }

        /* Takes a graph as input an adjacency matrix (see top for details) and a starting node */
        public Dijkstra(double[,] G, int s)
        {
            /* Check graph format and that the graph actually contains something */
            if (G.GetLength(0) < 1 || G.GetLength(0) != G.GetLength(1))
            {
                throw new ArgumentException("Graph error, wrong format or no nodes to compute");
            }

            int len = G.GetLength(0);

            Initialize(s, len);

            while (queue.Count > 0)
            {
                int u = GetNextVertex();

                /* Find the nodes that u connects to and perform relax */
                for (int v = 0; v < len; v++)
                {
                    /* Checks for edges with negative weight */
                    if (G[u, v] < 0)
                    {
                        throw new ArgumentException("Graph contains negative edge(s)");
                    }

                    /* Check for an edge between u and v */
                    if (G[u, v] > 0)
                    {
                        /* Edge exists, relax the edge */
                        if (dist[v] > dist[u] + G[u, v])
                        {
                            dist[v] = dist[u] + G[u, v];
                            path[v] = u;
                        }
                    }
                }
            }
        }
    }
}
