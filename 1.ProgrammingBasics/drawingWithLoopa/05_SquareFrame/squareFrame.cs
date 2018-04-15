using System;

namespace _05_SquareFrame
{
    public class squareFrame
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+ ");

            for (var m = 1; m <= n - 2; m++)
            {
                Console.Write("- ");
            }

            Console.Write("+");
            Console.WriteLine();

            for (var b = 1; b <= n - 2; b++)
            {
                Console.Write("| ");

                for (var v = 1; v <= n - 2; v++)
                {
                    Console.Write("- ");
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+ ");

            for (var m = 1; m <= n - 2; m++)
            {
                Console.Write("- ");
            }

            Console.Write("+");
        }
    }
}