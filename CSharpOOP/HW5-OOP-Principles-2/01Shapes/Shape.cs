namespace _01Shapes
{
    using System;
    public abstract class Shape
    {
        private double height;
        private double width;

        public double Height 
        {
            get
            {
                return this.height;
            }
            private set 
            {
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("Height should be greater than 0");
                }
                this.height = value;
            }
        }
        public double Width {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Wigth should be greater than 0");
                }
                this.width = value;
            }
        }
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("{0} ({1},{2})", this.GetType().Name, this.Height, this.Width);
        }
    }
}
