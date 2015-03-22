namespace HW2_DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    struct Point
    {
        private static readonly Point o = new Point();
        public Point(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Point O
        {
            get { return o; }
        }

        public override string ToString()
        {
            return "( " + this.X + ", " + this.Y + ", " + this.Z + " )";
            
        }
    }

    static class Distance
    {
        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y) + (p1.Z - p2.Z) * (p1.Z - p2.Z)); 
        }
    }

    class Path
    {
        private List<Point> pointsPath = new List<Point>();
        public List<Point> PointsPath
        {
            get
            {
                return pointsPath;
            }
            private set{}
        }
        public List<Point> AddPoint(Point p)
        {
            this.PointsPath.Add(p);
            return this.PointsPath;
        }
        public override string ToString()
        {
            return string.Join(" ", this.PointsPath);
        }
    }
    static class PathStorage 
    {
        public static void WritePath(Path path, string filePath)
        {
            File.WriteAllText(filePath, path.ToString());
        }
        public static Path ReadPath(string filePath)
        {
            Path pointsPath = new Path();
            string pathText = File.ReadAllText(filePath);
            int[] coords = Array.ConvertAll<string, int>(pathText.Split(new char[] { '(', ' ', ',', ')' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            for (int i = 0; i <= coords.Length - 3; i += 3)
            {
                pointsPath.AddPoint(new Point(coords[i], coords[i + 1], coords[i + 2]));
            }
            return pointsPath;
        }
    }

    class Program
    {
        static void Main()
        {
            Point p1 = new Point(1, 0, 0);
            Point p2 = new Point(-1, 0, 0);
            Console.WriteLine("Point p1 = {0}", p1);
            Console.WriteLine("Point p2 = {0}", p2);
            Console.WriteLine("Origin = {0}", Point.O);
            double dist = Distance.GetDistance(p1, p2);
            Console.WriteLine("Distance = {0}", dist);
            //Path path1 = new Path();
            //path1.AddPoint(p1);
            //path1.AddPoint(p2);
            //Console.WriteLine(path1);
            Path readPath = PathStorage.ReadPath("../../path1.txt");
            Console.WriteLine("Path read from file = {0}", readPath);
            PathStorage.WritePath(readPath, "../../pathout.txt");

        }

    }
}
