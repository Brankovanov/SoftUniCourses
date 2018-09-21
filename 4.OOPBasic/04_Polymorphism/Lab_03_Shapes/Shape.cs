namespace Lab_03_Shapes
{
    //Parent abstract class that holds the basic methods. 
    public abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
