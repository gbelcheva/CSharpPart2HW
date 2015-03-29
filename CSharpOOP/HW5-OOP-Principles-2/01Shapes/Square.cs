using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01Shapes
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }
        public override string ToString()
        {
            return string.Format("{0} ({1})", this.GetType().Name, this.Height);
        }
    }
}
