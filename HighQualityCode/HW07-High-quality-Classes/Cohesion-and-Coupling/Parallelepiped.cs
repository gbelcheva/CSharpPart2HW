﻿namespace CohesionAndCoupling
{
    using System;
    using Abstraction;
    
    public class Parallelepiped
    {
        private double width;
        private double height;
        private double depth;

        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
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

        public double Depth 
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(Messages.MustBePositive, "Depth"));
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = MathUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = MathUtils.CalcDistance2D(0, 0, this.Width, this.Height);

            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = MathUtils.CalcDistance2D(0, 0, this.Width, this.Depth);

            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = MathUtils.CalcDistance2D(0, 0, this.Height, this.Depth);

            return distance;
        }
    }
}
