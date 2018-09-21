using System;

namespace Lab_03_Shapes
{
    //Child class of Shape that holds the circle parameters and overriden versions of the Shape methods.
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                this.radius = value;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return (this.Radius * Math.PI) * 2;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}