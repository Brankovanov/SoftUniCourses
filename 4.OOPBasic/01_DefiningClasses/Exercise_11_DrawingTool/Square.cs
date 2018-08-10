namespace Exercise_11_DrawingTool
{
    //Creates a square and holds its sides.
    public class Square
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

        public Square(int widht, int lenght)
        {
            this.widht = widht;
            this.lenght = lenght;
        }
    }
}