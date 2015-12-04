namespace DijkstraLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DijkstraTest
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var totalCount = int.Parse(input[0]);
            var streetsCount = int.Parse(input[1]);
            var hostpitalsCount = int.Parse(input[3]);

            var hospitals = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);



            var graph = new Graph();

            for (int i = 0; i < townsCount; i++)
            {

                graph.AddNode((i + 1).ToString());
            }

            for (int i = 0; i < pathsCount; i++)
            {
                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                graph.AddConnection(input[0], input[1], int.Parse(input[2]), true);
            }

            double totalDistance = 0;
            var calculator = new DistanceCalculator();

            var distances = calculator.CalculateDistances(graph, source);  // Start from "G"
            var passDistance1 = distances[passTown1];
            var passDistance2 = distances[passTown2];

            if (passDistance1 <= passDistance2)
            {
                totalDistance += passDistance1;
                distances = calculator.CalculateDistances(graph, passTown1);
                passDistance2 = distances[passTown2];
                totalDistance += passDistance2;

                distances = calculator.CalculateDistances(graph, passTown2);
            }
            else
            {
                totalDistance += passDistance2;
                distances = calculator.CalculateDistances(graph, passTown2);
                passDistance2 = distances[passTown1];
                totalDistance += passDistance2;

                distances = calculator.CalculateDistances(graph, passTown1);
            }

            passDistance2 = distances[destination];
            totalDistance += passDistance2;


            Console.WriteLine(totalDistance);
        }
    }

    public class DistanceCalculator
    {
        public IDictionary<string, double> CalculateDistances(Graph graph, string startingNode)
        {
            if (!graph.Nodes.Any(n => n.Key == startingNode))
            {
                throw new ArgumentException("Starting node must be in graph.");
            }

            this.InitializeGraph(graph, startingNode);
            this.ProcessGraph(graph, startingNode);
            return this.ExtractDistances(graph);
        }

        private void InitializeGraph(Graph graph, string startingNode)
        {
            foreach (Node node in graph.Nodes.Values)
            {
                node.DistanceFromStart = double.PositiveInfinity;
            }

            graph.Nodes[startingNode].DistanceFromStart = 0;
        }

        private void ProcessGraph(Graph graph, string startingNode)
        {
            bool finished = false;
            var queue = graph.Nodes.Values.ToList();
            while (!finished)
            {
                var nextNode =
                    queue.OrderBy(n => n.DistanceFromStart)
                        .FirstOrDefault(n => !double.IsPositiveInfinity(n.DistanceFromStart));
                if (nextNode != null)
                {
                    this.ProcessNode(nextNode, queue);
                    queue.Remove(nextNode);
                }
                else
                {
                    finished = true;
                }
            }
        }

        private void ProcessNode(Node node, List<Node> queue)
        {
            var connections = node.Connections.Where(c => queue.Contains(c.Target));
            foreach (var connection in connections)
            {
                double distance = node.DistanceFromStart + connection.Distance;
                if (distance < connection.Target.DistanceFromStart)
                {
                    connection.Target.DistanceFromStart = distance;
                }
            }
        }

        private IDictionary<string, double> ExtractDistances(Graph graph)
        {
            return graph.Nodes.ToDictionary(n => n.Key, n => n.Value.DistanceFromStart);
        }
    }

    internal class Edge
    {
        internal Edge(Node target, double distance)
        {
            this.Target = target;
            this.Distance = distance;
        }

        internal Node Target { get; private set; }

        internal double Distance { get; private set; }
    }

    public class Graph
    {
        public Graph()
        {
            this.Nodes = new Dictionary<string, Node>();
        }

        internal IDictionary<string, Node> Nodes { get; private set; }

        public void AddNode(string name)
        {
            var node = new Node(name);
            this.Nodes.Add(name, node);
        }

        public void AddConnection(string fromNode, string toNode, int distance, bool twoWay)
        {
            this.Nodes[fromNode].AddConnection(this.Nodes[toNode], distance, twoWay);
        }
    }

    internal class Node
    {
        private readonly IList<Edge> connections;

        internal string Name { get; private set; }

        internal double DistanceFromStart { get; set; }

        internal IEnumerable<Edge> Connections
        {
            get { return connections; }
        }

        internal Node(string name)
        {
            this.Name = name;
            this.connections = new List<Edge>();
        }

        internal void AddConnection(Node targetNode, double distance, bool twoWay)
        {
            if (targetNode == null)
            {
                throw new ArgumentNullException("targetNode");
            }

            if (targetNode == this)
            {
                throw new ArgumentException("Node may not connect to itself.");
            }

            if (distance <= 0)
            {
                throw new ArgumentException("Distance must be positive.");
            }

            this.connections.Add(new Edge(targetNode, distance));
            if (twoWay)
            {
                targetNode.AddConnection(this, distance, false);
            }
        }
    }
}
