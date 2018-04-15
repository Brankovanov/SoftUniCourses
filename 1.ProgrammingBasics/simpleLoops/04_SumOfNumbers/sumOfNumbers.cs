using System;

namespace _04_SumOfNumbers
{
    public class sumOfNumbers
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var sum = 0;
            var num = 0;

            for (var i = 1; i <= input; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
                num = 0;
            }

            Console.WriteLine(sum);
        }
    }
}
