using System;

namespace _02_Square
{
    public class square
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var m = 1; m <= n; m++)
            {
                for (var p = 1; p <= n; p++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
