using System;

namespace _02_NumbersInReverse
{
    public class numbersInReverse
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (var n = input; n >= 1; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}
