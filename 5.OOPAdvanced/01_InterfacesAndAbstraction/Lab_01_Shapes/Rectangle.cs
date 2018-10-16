using System;

namespace Lab_01_Shapes
{
    //A rectangle class derived from IDrawable interface.
    class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');

            for (var i = 1; i < this.Height - 1; ++i)
            {
                Console.WriteLine();
                DrawLine(this.Width, '*', ' ');
            }

            Console.WriteLine();
            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);

            for (var i = 1; i < width - 2; ++i)
            {
                Console.Write(mid);
            }

            Console.Write(end);
        }
    }
}