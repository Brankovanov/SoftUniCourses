using System;

namespace Exercise_01_Box
{
    //Creates a box object that holds the boxe's length, width and height. 
    //It also holds methods for calculation the boxe's surface area, lateral surface area and volume.
    public class Box
    {
        private double length;
        private double width;
        private double height;

        internal double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative. ");
                }
            }
        }

        internal double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative. ");
                }
            }
        }

        internal double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative. ");
                }
            }
        }

        internal Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.height * this.width);
        }

        public double LateralSurface()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double Volume()
        {
            return this.length * this.height * this.width;
        }
    }
}