using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SquareOfStars
{
    public class squareOfStars
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (var first = 0; first <= input - 1; first++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (var rolls = 0; rolls <= input - 3; rolls++)
            {
                Console.Write("*");
                for (var space = 0; space <= input - 3; space++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                Console.WriteLine();
            }

            for (var last = 0; last <= input - 1; last++)
            {
                Console.Write("*");
            }
        }
    }
}
