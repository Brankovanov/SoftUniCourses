using System;

namespace _05_TrapezoidArea
{
    public class trapezoidArea
    {
        public static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var trapArea = (a + b) * (h / 2);

            Console.WriteLine(trapArea);
        }
    }
}
