using System;

namespace Lab_01_Shapes
{
    //A circle class derived from IDrawable interface.
    public class Circle : IDrawable
    {
        private int radius;

        public int Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public void Draw()
        {
            var r_in = this.Radius - 0.4;
            var r_out = this.Radius + 0.4;

            for (var y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < r_out; x += 0.5)
                {
                    var value = x * x + y * y;

                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}