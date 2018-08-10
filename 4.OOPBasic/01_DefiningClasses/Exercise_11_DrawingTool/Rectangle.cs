namespace Exercise_11_DrawingTool
{
    //Creates a rectangle and holds its widht and lenght.
    public class Rectangle
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

        public Rectangle(int widht, int lenght)
        {
            this.widht = widht;
            this.lenght = lenght;
        }
    }
}