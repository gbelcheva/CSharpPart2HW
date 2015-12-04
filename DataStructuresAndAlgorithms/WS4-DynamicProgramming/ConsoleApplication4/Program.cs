using System;
using System.Collections.Generic;
using System.Linq;

namespace Cheng.Algorithm
{
    public class Dijsktra
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var townsCount = int.Parse(input[0]);
            var pathsCount = int.Parse(input[1]);

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var source = input[0];
            var destination = input[1];

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var passTown1 = input[0];
            var passTown2 = input[1];

            var graph1 = new Dijsktra.Graph("My Graph");

            for (int i = 1; i <= townsCount; i++)
            {
                graph1.AddNode(new Dijsktra.Graph.Vertex(i.ToString(), i, i));

            }

            for (int i = 0; i < pathsCount; i++)
            {
                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var town = input[0];
                var connection = input[1];
                var distance = int.Parse(input[2]);

                graph1.AddEdge(town, connection, distance);
                graph1.AddEdge(connection, town, distance);

            }

            //var graph = new Dijsktra.Graph("Graph Name");

            //graph.AddNode(new Dijsktra.Graph.Vertex("node 1", 0, 0));
            //graph.AddNode(new Dijsktra.Graph.Vertex("node 2", 3, 2));
            //graph.AddNode(new Dijsktra.Graph.Vertex("node 3", 2, 5));
            //graph.AddNode(new Dijsktra.Graph.Vertex("node 4", 5, 3));
            //graph.AddNode(new Dijsktra.Graph.Vertex("node 5", 5, 3));
            //graph.AddEdge("node 1", "node 2", 3);
            //graph.AddEdge("node 1", "node 3", 4);
            //graph.AddEdge("node 2", "node 3", 2);
            //graph.AddEdge("node 2", "node 4", 1);
            //graph.AddEdge("node 3", "node 4", 1);
            //graph.AddEdge("node 4", "node 5", 1);


            //var shortestPath = new Dijsktra();
            //shortestPath.analyze(graph, "node 1", "node 5");
            //shortestPath.analyze(graph1, source, "11");

            //Console.WriteLine("Shortest path: {0}\nTotal Distant: {1}", string.Join(" -> ", shortestPath.Path.Select(p => p.Name).ToList()), shortestPath.Min);


            var totalDistance = 0;

            var shortestPath = new Dijsktra();
            shortestPath.analyze(graph1, source, passTown1);
            var passDistance1 = shortestPath.Min;
            graph1.Reset();
            shortestPath.analyze(graph1, source, passTown2);
            var passDistance2 = shortestPath.Min;

            if (passDistance1 < passDistance2)
            {
                totalDistance += passDistance1;
                graph1.Reset();
                shortestPath.analyze(graph1, passTown1, passTown2);
                totalDistance += shortestPath.Min;

                graph1.Reset();
                shortestPath.analyze(graph1, passTown2, destination);
            }
            else
            {
                totalDistance += passDistance2;
                graph1.Reset();
                shortestPath.analyze(graph1, passTown2, passTown1);
                totalDistance += shortestPath.Min;

                graph1.Reset();
                shortestPath.analyze(graph1, passTown1, destination);
            }

            totalDistance += shortestPath.Min;


            Console.WriteLine(totalDistance);
        }

        public class FibonacciHeap
        {
            public List<Node> root;
            private Node min;

            public class Node
            {
                public int value;
                public Node parent;
                public List<Node> children;
                private Boolean mark;
                private Graph.Vertex theref;

                public Node(int value, Graph.Vertex theref)
                {
                    this.value = value;
                    children = new List<Node>();
                    parent = null;
                    mark = false;
                    this.theref = theref;
                }

                public int getDegree()
                {
                    return children.Count;
                }

                public Boolean getMark()
                {
                    return mark;
                }

                public void setMark(Boolean mark)
                {
                    this.mark = mark;
                }

                public Graph.Vertex getRef()
                {
                    return theref;
                }
            }

            public FibonacciHeap()
            {
                root = new List<Node>();
                min = null;
            }

            public void Clear()
            {
                root.Clear();
                min = null;
            }

            public Node add(int value, Graph.Vertex theref)
            {
                Node node = new Node(value, theref);

                root.Add(node);

                if (min == null || min.value > value)
                    min = node;

                return node;
            }

            public Node extractMin()
            {
                Node result, node;
                Dictionary<int, Node> map = new Dictionary<int, Node>();
                int current;

                result = min;
                if (min != null)
                {
                    foreach (Node n in result.children)
                    {
                        n.parent = null;
                        root.Add(n);
                    }

                    root.Remove(result);

                    min = null;

                    current = root.Count - 1;
                    while (current >= 0)
                    {
                        node = root[current];
                        if (min == null || min.value > node.value)
                            min = node;

                        int degree = node.getDegree();
                        while (map.ContainsKey(degree) == true)
                        {
                            Node conflict;

                            conflict = map[degree];
                            map.Remove(degree);

                            if (conflict.value < node.value)
                            {
                                node.parent = conflict;
                                conflict.children.Add(node);
                                root.Remove(node);
                                node = conflict;
                            }
                            else if (conflict.value > node.value)
                            {
                                conflict.parent = node;
                                node.children.Add(conflict);
                                root.Remove(conflict);
                            }

                            degree = node.getDegree();
                        }

                        map.Add(degree, node);

                        current--;
                    }
                }

                return result;
            }

            private void cut(Node node)
            {
                node.parent.children.Remove(node);
                node.parent = null;
                root.Add(node);
                node.setMark(false);
            }

            private void cascading_cut(Node node)
            {
                Node parent = node.parent;

                if (parent != null)
                {
                    if (node.getMark() == false)
                        node.setMark(true);
                    else
                    {
                        cut(node);
                        cascading_cut(parent);
                    }
                }
            }

            public void decreaseKey(Node node, int value)
            {
                Node parent;

                if (value > node.value)
                {
                    throw new Exception("unable to decreasekey as current value is smaller than the parameter value");
                }

                node.value = value;
                parent = node.parent;
                if (parent != null && value < parent.value)
                {
                    cut(node);
                    cascading_cut(parent);
                }

                if (value < min.value)
                    min = node;
            }
        }

        public class Graph
        {
            public class Edge
            {
                private String ffrom, fto;
                private int fdistant;

                public Edge(String from, String to, int distant)
                {
                    ffrom = from;
                    fto = to;
                    fdistant = distant;
                }

                public String from
                {
                    get { return ffrom; }
                }

                public String to
                {
                    get { return fto; }
                }

                public int distant
                {
                    get { return fdistant; }
                }

                public void SetDistant(int distant)
                {
                    fdistant = distant;
                }

                public void AddDistant(int distant)
                {
                    fdistant += distant;
                    if (fdistant < 0)
                        fdistant = 0;
                }
            }

            public class Vertex
            {
                private String cname;
                private int cx, cy;
                private Dictionary<String, Edge> edges;

                private int min;
                private Vertex minNode;

                FibonacciHeap.Node fibNode;

                public Vertex(String name, int x, int y)
                {
                    cname = name;
                    cx = x;
                    cy = y;

                    edges = new Dictionary<string, Edge>();

                    min = int.MaxValue;
                    minNode = null;
                    fibNode = null;
                }

                public String Name
                {
                    get { return cname; }
                }

                public int X
                {
                    get { return cx; }
                }

                public int Y
                {
                    get { return cy; }
                }

                public void Clear()
                {
                    edges.Clear();
                }

                public void AddEdge(String to, int distant)
                {
                    if (!edges.ContainsKey(to))
                        edges.Add(to, new Edge(cname, to, distant));
                }

                public void SetEdge(string to, int distant)
                {
                    Edge e;
                    if (edges.TryGetValue(to, out e))
                        e.SetDistant(distant);
                }

                public void AddDistant(string to, int distant)
                {
                    Edge e;
                    if (edges.TryGetValue(to, out e))
                        e.AddDistant(distant);
                }

                public Boolean GetEdge(String to, out Edge result)
                {
                    return edges.TryGetValue(to, out result);
                }

                public ICollection<Edge> Edges
                {
                    get { return edges.Values; }
                }

                public void SetMin(int distant, Vertex node)
                {
                    if (distant < min)
                    {
                        min = distant;
                        minNode = node;
                    }
                }

                public int GetMin()
                {
                    return min;
                }

                public Boolean hasFibNode()
                {
                    return fibNode != null;
                }

                public FibonacciHeap.Node FibNode
                {
                    get { return this.fibNode; }
                    set { this.fibNode = value; }
                }

                public Vertex from
                {
                    get { return minNode; }
                }

                public void Reset()
                {
                    fibNode = null;
                    min = int.MaxValue;
                }
            }

            private Dictionary<String, Vertex> nodes;
            private String name;

            public Graph(String name)
            {
                nodes = new Dictionary<String, Vertex>();
                this.name = name;
            }

            public String Name
            {
                get { return name; }
            }

            public int Count
            {
                get { return nodes.Count; }
            }

            public void AddNode(Vertex node)
            {
                nodes.Add(node.Name, node);
            }

            public void RemoveNode(String nodeName)
            {
                nodes.Remove(nodeName);
            }

            public void AddEdge(String from, String to, int distant)
            {
                Vertex node;
                if (nodes.TryGetValue(from, out node))
                {
                    node.AddEdge(to, distant);
                }
            }

            public void SetEdge(string from, string to, int distant)
            {
                Vertex node;
                if (nodes.TryGetValue(from, out node))
                {
                    node.SetEdge(to, distant);
                }
            }

            public void AddDistant(string from, string to, int distant)
            {
                Vertex node;
                if (nodes.TryGetValue(from, out node))
                {
                    node.AddDistant(to, distant);
                }
            }

            public ICollection<Vertex> Vertices
            {
                get { return nodes.Values; }
            }

            public Vertex GetVertex(String name)
            {
                Vertex node;
                return nodes.TryGetValue(name, out node) ? node : null;
            }

            public void Reset()
            {
                foreach (Vertex v in Vertices)
                    v.Reset();
            }
        }

        /// <summary>
        /// shortest path result
        /// </summary>
        private LinkedList<Graph.Vertex> sp;

        /// <summary>
        /// shortest path distant in the path
        /// </summary>
        private int min;


        public Dijsktra()
        {
            sp = new LinkedList<Graph.Vertex>();
            min = int.MaxValue;
        }


        /// <summary>
        /// analyse the graph for shortest path
        /// </summary>
        /// <param name="graph">graph to be analyzed</param>
        /// <param name="startName">starting vertex</param>
        /// <param name="destinationName">terminating vertex</param>
        /// <returns>the shortest path between starting and terminating vertices; -1 if start and terminate are not connected</returns>
        public int analyze(Graph graph, String startName, String destinationName)
        {
            FibonacciHeap fibheap = new FibonacciHeap();
            Dictionary<String, Graph.Vertex> S = new Dictionary<String, Graph.Vertex>();

            Graph.Vertex start = graph.GetVertex(startName);
            Graph.Vertex term = graph.GetVertex(destinationName);
            Graph.Vertex current, last;

            int Smax = graph.Vertices.Count;

            start.SetMin(0, start);
            current = start;
            last = null;

            fibheap.Clear();
            while (S.Count < Smax && current != last)
            {
                last = current;
                S.Add(current.Name, current);

                foreach (Graph.Edge e in current.Edges)
                { // O(m)
                    if (!S.ContainsKey(e.to))
                    { // v is not in S ... O(1) as
                        // it is using hash table
                        Graph.Vertex v = graph.GetVertex(e.to);
                        v.SetMin(current.GetMin() + e.distant, current);

                        if (v.hasFibNode())
                            fibheap.decreaseKey(v.FibNode, v.GetMin());
                        else
                            v.FibNode = fibheap.add(v.GetMin(), v);

                    }
                }

                FibonacciHeap.Node minNode = fibheap.extractMin();
                if (minNode != null) // it will be null if all the nodes have been
                    // added into S
                    current = (Graph.Vertex)minNode.getRef();
            }

            sp.Clear();

            //if (S.Count < Smax)
            //    return -1;

            current = term;
            min = term.GetMin();

            if (min == int.MaxValue)
                return -1;

            while (current != start)
            {
                sp.AddFirst(current);
                current = current.from;
            }
            sp.AddFirst(start);

            return min;
        }




        /// <summary>
        /// get the shortest distant between starting and terminating vertices
        /// </summary>
        public int Min
        {
            get
            {
                return min;
            }
        }


        /// <summary>
        /// get the shortest path result
        /// </summary>
        public LinkedList<Graph.Vertex> Path
        {
            get
            {
                return sp;
            }
        }


    }
}