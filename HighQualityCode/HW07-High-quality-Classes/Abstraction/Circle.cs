namespace Abstraction
{
    using System;
    
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius) 
            : base()
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(Messages.MustBePositive, "Radius"));
                }

                this.radius = value;
            }
        }

        public override double GetPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double GetSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
