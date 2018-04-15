using System;

namespace _03_EvenOrOdd
{
    public class evenOrOdd
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num % 2 != 0)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }
        }
    }
}
