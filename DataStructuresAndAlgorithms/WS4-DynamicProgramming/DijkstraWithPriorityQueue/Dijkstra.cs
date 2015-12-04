namespace DijkstraWithPriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dijkstra
    {
        public static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            var queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = double.PositiveInfinity;
            }

            source.DijkstraDistance = 0.0d;
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();

                if (double.IsPositiveInfinity(currentNode.DijkstraDistance))
                {
                    break;
                }

                foreach (var neighbor in graph[currentNode])
                {
                    var potDistance = currentNode.DijkstraDistance + neighbor.Distance;
                    if (potDistance < neighbor.Node.DijkstraDistance)
                    {
                        neighbor.Node.DijkstraDistance = potDistance;
                        queue.Enqueue(neighbor.Node);
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

            var nodes = new List<Node>();

            for (int i = 1; i <= townsCount; i++)
            {
                nodes.Add(new Node(i));
            }

            var graph1 = new Dictionary<Node, List<Connection>>();

            for (int i = 0; i < pathsCount; i++)
            {
                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                var town = int.Parse(input[0]);
                var connection = int.Parse(input[1]);
                var distance = int.Parse(input[2]);
                var currentNode1 = nodes[town - 1];
                var currentConnection1 = new Connection(new Node(connection), distance);
                var currentNode2 = nodes[connection - 1];
                var currentConnection2 = new Connection(new Node(town), distance);

                if (!graph1.ContainsKey(currentNode1))
                {
                    graph1[currentNode1] = new List<Connection>();
                }

                graph1[currentNode1].Add(currentConnection1);

                if (!graph1.ContainsKey(currentNode2))
                {
                    graph1[currentNode2] = new List<Connection>();
                }

                graph1[currentNode2].Add(currentConnection2);

            }

            Node sourceNode = nodes[source];

            DijkstraAlgorithm(graph1, sourceNode);

            for (int i = 0; i < nodes.Count; i++)
            {
                Console.Write("Distance from {0} to {1} ", sourceNode.Id, i);
                Console.WriteLine(nodes[i].DijkstraDistance);
            }
        }
    }
}
