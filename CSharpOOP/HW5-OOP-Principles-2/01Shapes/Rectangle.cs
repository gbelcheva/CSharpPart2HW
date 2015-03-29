using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(height, width)
        {
        }
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
