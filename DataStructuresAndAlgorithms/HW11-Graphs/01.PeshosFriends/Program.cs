namespace PeshosFriends
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var pointsCount = int.Parse(input[0]);
            var streetsCount = int.Parse(input[1]);
            var hospitalCounts = int.Parse(input[2]);

            var hospitals = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();



            var graph = new double[pointsCount + 1, pointsCount + 1];

            for (int i = 0; i < streetsCount; i++)
            {
                var edges = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

                graph[edges[0], edges[1]] = edges[2];
                graph[edges[1], edges[0]] = edges[2];
            }


            //var array = new double[,]
            //{
            //    { 0, 2, 5, 0, 0},
            //    { 0, 0, 0, 4, 0},
            //    { 0, 6, 0, 0, 8},
            //    { 0, 0, 0, 0, 9},
            //    { 0, 0, 2, 0, 0}
            //};

            var d = new Dijkstra(graph, hospitals[0]);

            Console.WriteLine(d.dist[2]);

            Console.WriteLine(string.Join(" -> ", d.path));
        }
    }
}
