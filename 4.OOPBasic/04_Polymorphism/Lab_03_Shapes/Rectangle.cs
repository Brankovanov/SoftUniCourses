namespace Lab_03_Shapes
{
    //Child class of Shape that holds the rectangle parameters and overriden versions of the Shape methods.
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public Rectangle(double height, double widht)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculatePerimeter()
        {
            return (this.height + this.width) * 2;
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}