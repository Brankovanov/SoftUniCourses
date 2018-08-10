using System;

namespace Exercise_11_DrawingTool
{
    //Creates a drawing tool that holds the figure widht and lenght.
    public class DrawingTools
    {
        private int widht;
        private int lenght;

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

        public int Lenght
        {
            get
            {
                return this.lenght;
            }
            set
            {
                this.lenght = value;
            }
        }

        public DrawingTools(int widht, int lenght)
        {
            this.widht = widht;
            this.lenght = lenght;
        }

        public void Draw(int widht, int lenght)
        {
            Console.WriteLine("|" + new String('-', widht) + "|");

            for (var row = 1; row <= lenght - 2; row++)
            {
                Console.WriteLine("|" + new String(' ', widht) + "|");
            }

            Console.WriteLine("|" + new String('-', widht) + "|");
        }
    }
}