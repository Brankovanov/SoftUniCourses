using System;

namespace Lab_06_MathPower
{
    public class mathPower
    {
        public static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());

            var answer = NumPower(num, power);

            Console.WriteLine(answer);
        }

        static double NumPower(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
