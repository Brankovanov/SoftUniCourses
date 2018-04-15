using System;

namespace _09_SumOfDigits
{
    public class sumOfDigits
    {
        public static void Main(string[] args)
        {
            var num = Console.ReadLine();

            var sum = 0;

            foreach(var ch in num)
            {
                sum = sum + int.Parse(ch.ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
