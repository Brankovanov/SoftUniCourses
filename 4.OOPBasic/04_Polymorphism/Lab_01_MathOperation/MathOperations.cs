namespace Lab_01_MathOperation
{
    //Creates math operations object that has three different add methods.
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }
}