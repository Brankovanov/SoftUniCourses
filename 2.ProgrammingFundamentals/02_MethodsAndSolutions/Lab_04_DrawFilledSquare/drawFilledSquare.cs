using System;

namespace Lab_04_DrawFilledSquare
{
    public class drawFilledSquare
    {
        public static void Main(string[] args)
        {
            var intNum = int.Parse(Console.ReadLine());

            DrawFilledSquare(intNum);
        }

        static void FloorAndCeiling(int intNum)
        {
            for (var number = 2 * intNum; number >= 1; number--)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }

        static void Body(int intNum)
        {
            for (var bodySize = intNum - 2; bodySize >= 1; bodySize--)
            {
                Console.Write("-");
                for (var number = 1; number <= (2 * intNum) - 2; number++)
                {
                    if (number % 2 != 0 || number == 1)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }

                Console.Write("-");
                Console.WriteLine();
            }
        }

        static void DrawFilledSquare(int intNum)
        {
            FloorAndCeiling(intNum);
            Body(intNum);
            FloorAndCeiling(intNum);
        }
    }
}
