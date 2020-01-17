using System;

namespace Lab_02_Shapes
{
    public class Circle:Shape
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
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string Draw()
        {
            var drawing = string.Empty;

            for(var diameter = 0; diameter<this.Radius*2;diameter++)
            {
                drawing += new string(' ', (int)this.Radius * 2 - diameter - 1) + '*' 
                    + new string(' ', diameter * 2) + '*'+new string(' ', (int)this.Radius * 2 - diameter - 1) 
                    + Environment.NewLine;
            }

            var counter = 0;

            for(var diameter = this.Radius * 2; diameter>0; diameter--)
            {               
                drawing += new string(' ', counter) + '*'
                    + new string(' ', (int)diameter) + new string(' ', (int)diameter-1) +'*'
                    + Environment.NewLine;
                counter++;
            }

            return drawing;
        }
    }
}
