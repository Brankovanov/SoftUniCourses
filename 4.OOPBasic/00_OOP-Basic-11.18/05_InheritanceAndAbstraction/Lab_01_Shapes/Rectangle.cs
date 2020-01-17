using System;

namespace Lab_01_Shapes
{
    public class Rectangle : IDrawable
    {
        private int height;
        private int widht;

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

        public int Widht
        {
            get
            {
                return this.widht;
            }
            set
            {
                this.widht = value;
            }
        }

        public Rectangle(int height, int widht)
        {
            this.Height = height;
            this.Widht = widht;
        }

        public void Draw()
        {
            Console.WriteLine(new string('*', this.Widht));

            for (var line = height - 2; height > 0; height--)
            {
                Console.WriteLine("*" + new string(' ', this.Widht - 2) + "*");
            }

            Console.WriteLine(new string('*', this.Widht));
        }
    }
}
