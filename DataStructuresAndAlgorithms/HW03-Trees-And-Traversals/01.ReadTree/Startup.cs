namespace _01.ReadTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            //            7
            //          2 4
            //          3 2
            //          5 0
            //          3 5
            //          5 6
            //          5 1

            var pairs = new List<KeyValuePair<int, int>>();
            int nodesCount = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < nodesCount - 1; i++)
            {
                var pairInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int parent = Int32.Parse(pairInput[0]);
                int child = Int32.Parse(pairInput[1]);

                pairs.Add(new KeyValuePair<int, int>(parent, child));
            }

            HashSet<int> nodes = new HashSet<int>();

            foreach (var p in pairs)
            {
                nodes.Add(p.Key);
                nodes.Add(p.Value);
            }

            int root = GetRootNode(pairs, nodes);
            Console.WriteLine("Root: {0}", root);

            List<int> leafs = GetLeafNodes(pairs, nodes);
            Console.WriteLine("Leafs: {0}", string.Join(" ", leafs));

            List<int> middles = GetMiddleNodes(pairs, nodes);
            Console.WriteLine("Middle nodes: {0}", string.Join(" ", middles));

            Queue<int> maxPath = GetLongestPath(pairs);
            Console.WriteLine("Longest path: {0}", string.Join(" ", maxPath));

            Console.WriteLine("Enter sum to search:");
            int inputSum = Int32.Parse(Console.ReadLine());
            HashSet<Queue<int>> foundPaths = GetPathsByNodeSum(pairs, inputSum);

            foreach (var path in foundPaths)
            {
                Console.WriteLine("Found path: {0}", string.Join(" ", path));
            }
        }

        private static HashSet<Queue<int>> GetPathsByNodeSum(List<KeyValuePair<int, int>> pairs, int inputSum)
        {
            HashSet<Queue<int>> foundPaths = new HashSet<Queue<int>>();
            foreach (var p1 in pairs)
            {
                var currentLink = p1.Value;
                Queue<int> currentPath = new Queue<int>();
                currentPath.Enqueue(p1.Key);
                if (currentPath.Sum() == inputSum)
                {
                    foundPaths.Add(new Queue<int>(currentPath));
                }

                currentPath.Enqueue(p1.Value);
                if (currentPath.Sum() == inputSum)
                {
                    foundPaths.Add(new Queue<int>(currentPath));
                }

                foreach (var p2 in pairs)
                {
                    if (p2.Key == currentLink)
                    {
                        currentPath.Enqueue(p2.Value);
                        currentLink = p2.Value;
                        if (currentPath.Sum() == inputSum)
                        {
                            foundPaths.Add(new Queue<int>(currentPath));
                        }
                    }
                }
            }

            return foundPaths;
        }

        private static Queue<int> GetLongestPath(List<KeyValuePair<int, int>> pairs)
        {
            Queue<int> maxPath = new Queue<int>();
            foreach (var p1 in pairs)
            {
                var currentLink = p1.Value;
                Queue<int> currentPath = new Queue<int>();
                currentPath.Enqueue(p1.Key);
                currentPath.Enqueue(p1.Value);

                foreach (var p2 in pairs)
                {
                    if (p2.Key == currentLink)
                    {
                        currentPath.Enqueue(p2.Value);
                        currentLink = p2.Value;
                    }
                }

                if (currentPath.Count > maxPath.Count)
                {
                    maxPath = new Queue<int>(currentPath);
                }
            }

            return maxPath;
        }

        private static List<int> GetMiddleNodes(List<KeyValuePair<int, int>> pairs, HashSet<int> nodes)
        {
            List<int> middles = new List<int>();
            foreach (var n in nodes)
            {
                bool isMiddle = false;
                foreach (var p1 in pairs)
                {
                    if (p1.Key == n)
                    {
                        foreach (var p2 in pairs)
                        {
                            if (p2.Value == n)
                            {
                                isMiddle = true;
                                break;
                            }
                        }
                    }

                    if (isMiddle)
                    {
                        break;
                    }
                }

                if (isMiddle)
                {
                    middles.Add(n);
                }
            }

            return middles;
        }

        private static List<int> GetLeafNodes(List<KeyValuePair<int, int>> pairs, HashSet<int> nodes)
        {
            List<int> leafs = new List<int>();
            foreach (var n in nodes)
            {
                bool isLeaf = true;
                foreach (var p in pairs)
                {
                    if (p.Key == n)
                    {
                        isLeaf = false;
                        break;
                    }
                }

                if (isLeaf)
                {
                    leafs.Add(n);
                }
            }

            return leafs;
        }

        private static int GetRootNode(List<KeyValuePair<int, int>> pairs, HashSet<int> nodes)
        {
            int root = 0;
            foreach (var n in nodes)
            {
                bool isParent = true;
                foreach (var p in pairs)
                {
                    if (p.Value == n)
                    {
                        isParent = false;
                        break;
                    }
                }

                if (isParent)
                {
                    root = n;
                }
            }

            return root;
        }
    }
}
