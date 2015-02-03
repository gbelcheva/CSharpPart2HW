using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Polygon
{
    class PolygonPerArea
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Polygon poly = new Polygon();
            poly.Points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var allNumbers = Console.ReadLine().Split(' ').Take(2);
                float[] coord = allNumbers.Select(d => Convert.ToSingle(d)).ToArray();
                Point tmpPoint = new Point() { X = coord[0], Y = coord[1] };
                poly.Points.Add(tmpPoint);
            }
            float[] distances = new float[n];
            float perimeter = 0;
            float area = 0;
            for (int i = 0; i < n - 1; i++)
            {
                distances[i] = (float)Math.Sqrt((poly.Points[i + 1].X - poly.Points[i].X) * (poly.Points[i + 1].X - poly.Points[i].X) + (poly.Points[i + 1].Y - poly.Points[i].Y) * (poly.Points[i + 1].Y - poly.Points[i].Y));
                perimeter = perimeter + distances[i];
                area = area + ((poly.Points[i].Y + poly.Points[i + 1].Y) / 2) * (poly.Points[i + 1].X - poly.Points[i].X);
            }
            distances[n - 1] = (float)Math.Sqrt((poly.Points[0].X - poly.Points[n - 1].X) * (poly.Points[0].X - poly.Points[n - 1].X) + (poly.Points[0].Y - poly.Points[n - 1].Y) * (poly.Points[0].Y - poly.Points[n - 1].Y));
            perimeter = perimeter + distances[n - 1];
            area = area + ((poly.Points[n - 1].Y + poly.Points[0].Y) / 2) * (poly.Points[0].X - poly.Points[n - 1].X);
            Console.WriteLine("perimeter = {0:0.00} \narea = {1:0.00}", perimeter, area);
        }
    }
    class Point
    {
        public float X { get; set; }
        public float Y { get; set; }
    }

    class Polygon
    {
        public List<Point> Points { get; set; }
    }


}
