namespace _02_Point_Rectangle
{
    public class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        public Point TopLeft
        {
            get
            {
                return this.topLeft;
            }
            set
            {
                this.topLeft = value;
            }
        }

        public Point BottomRight
        {
            get
            {
                return this.bottomRight;
            }
            set
            {
                this.bottomRight = value;
            }
        }

        public bool Contains (Point outerPoint)
        {
            if((outerPoint.X>=TopLeft.X &&
                outerPoint.X <= BottomRight.X) && 
                (outerPoint.Y>=TopLeft.Y && 
                outerPoint.Y<=BottomRight.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            this.TopLeft = new Point(topLeftX, topLeftY);
            this.BottomRight = new Point(bottomRightX, bottomRightY);
        }
    }
}
