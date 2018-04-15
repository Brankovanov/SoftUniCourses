using System;

namespace _03_SecondSquare
{
    public class secondSquare
    {
        public static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            for (var m = 1; m <= n; m++)
            {
                Console.Write("*");

                for (var p = 1; p <= n-1; p++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}

