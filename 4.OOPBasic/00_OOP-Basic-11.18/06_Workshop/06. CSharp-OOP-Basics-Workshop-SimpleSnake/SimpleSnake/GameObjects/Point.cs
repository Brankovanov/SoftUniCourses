using System;

namespace SimpleSnake.GameObjects
{
    public class Point
    {
        private int leftX;
        private int topY;

        public int LeftX
        {
            get
            {
                return this.leftX;
            }
            set
            {
                this.leftX = value;
            }
        }

        public int TopY
        {
            get
            {
                return this.topY;
            }
            set
            {
                this.topY = value;
            }
        }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, this.TopY);
            Console.Write(symbol);
        }

        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX, topY);
            Console.Write(symbol);
        }

        public Point(int leftX, int topY)
        {
            this.LeftX = leftX;
            this.TopY = topY;
        }
    }
}
