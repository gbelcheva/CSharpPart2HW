﻿namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        { 
            get
            {
                return this.width;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(Messages.MustBePositive, "Width"));
                }

                this.width = value;
            }
        }

        public double Height 
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(Messages.MustBePositive, "Height"));
                }

                this.height = value;
            }
        }

        public override double GetPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double GetSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
