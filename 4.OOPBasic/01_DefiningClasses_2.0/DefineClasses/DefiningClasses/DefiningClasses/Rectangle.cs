namespace DefiningClasses
{
    public class Rectangle
    {
        private string id;
        private double widht;
        private double height;
        private double topLeftHorizontal;
        private double topLeftVertical;
        private double lowRightHorizontal;
        private double lowRightVertical;

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

        public double TopLeftHorizontal
        {
            get
            {
                return this.topLeftHorizontal;
            }
            set
            {
                this.topLeftHorizontal = value;
            }
        }

        public double TopLeftVertical
        {
            get
            {
                return this.topLeftVertical;
            }
            set
            {
                this.topLeftVertical = value;
            }
        }

        public double LowRightHorizontal
        {
            get
            {
                return this.lowRightHorizontal;
            }
            set
            {
                this.lowRightHorizontal = value;
            }
        }

        public double LowRightVertical
        {
            get
            {
                return this.lowRightVertical;
            }
            set
            {
                this.lowRightVertical = value;
            }
        }

        public Rectangle(string id, double widht, double height,
            double topLeftHorizontal, double topLeftVertical)
        {
            this.Id = id;
            this.Widht = widht;
            this.Height = height;
            this.TopLeftHorizontal = topLeftHorizontal;
            this.TopLeftVertical = topLeftVertical;
            this.LowRightHorizontal = topLeftHorizontal - widht;
            this.LowRightVertical = topLeftVertical - height;
        }

        public string CheckForIntersections(Rectangle secondRectangle)
        {
            if (this.TopLeftHorizontal > secondRectangle.TopLeftHorizontal ||
                this.TopLeftVertical > secondRectangle.TopLeftVertical)
            {
                return "false";
            }

            if (this.LowRightHorizontal < secondRectangle.LowRightHorizontal ||
                this.LowRightVertical < secondRectangle.LowRightVertical)
            {
                return "false";
            }

            return "true";
        }
    }
}
