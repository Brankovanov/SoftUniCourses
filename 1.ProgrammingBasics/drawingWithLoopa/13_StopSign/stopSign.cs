using System;

namespace _13_StopSign
{
    public class stopSign
    {
        public static void Main(string[] args)
        {
            //Вход.

            var input = int.Parse(Console.ReadLine());
            var inside = (input * 2) - 1;
            var outside = input;

            //Горна част.

            for (var upLeft = 0; upLeft <= input; upLeft++)
            {
                Console.Write(".");
            }

            for (var midd = 1; midd <= (input * 2) + 1; midd++)
            {
                Console.Write("_");
            }

            for (var upRight = 0; upRight <= input; upRight++)
            {
                Console.Write(".");
            }

            Console.WriteLine();

            for (var rolls = 1; rolls <= input; rolls++)
            {
                for (var upLeftOutside = 0; upLeftOutside < outside; upLeftOutside++)
                {
                    Console.Write(".");
                }

                Console.Write("//");

                for (var middle = 1; middle <= inside; middle++)
                {
                    Console.Write("_");
                }

                Console.Write("\\\\");

                for (var upRightOutside = 0; upRightOutside < outside; upRightOutside++)
                {
                    Console.Write(".");
                }

                outside--;
                inside = inside + 2;
                Console.WriteLine();
            }

            //Среда.

            Console.Write("//");

            for (var middleLeft = 1; middleLeft <= (inside - 5) / 2; middleLeft++)
            {
                Console.Write("_");
            }

            Console.Write("STOP!");

            for (var middleRight = 1; middleRight <= (inside - 5) / 2; middleRight++)
            {
                Console.Write("_");
            }

            Console.Write("\\\\");
            Console.WriteLine();

            //Долна част.

            for (var rollsDown = 1; rollsDown <= input; rollsDown++)
            {
                for (var downLeftOutside = 0; downLeftOutside < outside; downLeftOutside++)
                {
                    Console.Write(".");
                }

                Console.Write("\\\\");

                for (var middle = 1; middle <= inside; middle++)
                {
                    Console.Write("_");
                }

                Console.Write("//");

                for (var downRightOutside = 0; downRightOutside < outside; downRightOutside++)
                {
                    Console.Write(".");
                }

                outside++;
                inside = inside - 2;
                Console.WriteLine();
            }
        }
    }
}
