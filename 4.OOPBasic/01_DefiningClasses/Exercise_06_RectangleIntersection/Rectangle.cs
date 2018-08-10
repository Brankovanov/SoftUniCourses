namespace Exercise_06_RectangleIntersection
{
    //Creates a rectangle object that holds the rectangle id, widht, height and the coordinates of the left upper corner and the low right corner.
    public class Rectangle
    {
        private string id;
        private double widht;
        private double height;
        private double upperLeftCornerHorizontal;
        private double upperLeftCornerVertical;
        private double lowerRightCornerHorizontal;
        private double lowerRightCornerVertical;

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public double Widht
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

        public double Height
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

        public double UpperLeftCornerHorizontal
        {
            get
            {
                return this.upperLeftCornerHorizontal;
            }
            set
            {
                this.upperLeftCornerHorizontal = value;
            }
        }

        public double UpperLeftCornerVertical
        {
            get
            {
                return this.upperLeftCornerVertical;
            }
            set
            {
                this.upperLeftCornerVertical = value;
            }
        }

        public double LowerRightCornerHorizontal
        {
            get
            {
                return this.lowerRightCornerHorizontal;
            }
            set
            {
                this.lowerRightCornerHorizontal = value;
            }
        }

        public double LowerRightCornerVertical
        {
            get
            {
                return this.lowerRightCornerVertical;
            }
            set
            {
                this.lowerRightCornerVertical = value;
            }
        }

        public Rectangle(string id, double widht, double height, double upperLeftCornerHorizontal, double upperLeftCornerVertical)
        {
            this.id = id;
            this.widht = widht;
            this.height = height;
            this.upperLeftCornerHorizontal = upperLeftCornerHorizontal;
            this.upperLeftCornerVertical = upperLeftCornerVertical;
            this.lowerRightCornerHorizontal = upperLeftCornerHorizontal + widht;
            this.lowerRightCornerVertical = upperLeftCornerVertical - height;
        }
    }
}