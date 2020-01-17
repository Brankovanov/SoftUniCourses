using System;

namespace Lab_01_Shapes
{
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
            var radIn = this.Radius - 0.4;
            var radOut = this.Radius + 0.4;

            for (var y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < radOut; x += 0.5)
                {
                    var value = x * x + y * y;

                    if (value >= radIn * radIn && value <= radOut * radOut)
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
