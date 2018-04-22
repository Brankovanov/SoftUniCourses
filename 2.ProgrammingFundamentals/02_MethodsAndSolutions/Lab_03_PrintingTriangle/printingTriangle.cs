using System;

namespace Lab_03_PrintingTriangle
{
    public class printingTriangle
    {
        public static void Main(string[] args)
        {
            var inputNum = int.Parse(Console.ReadLine());

            PrintingTriangle(inputNum);
        }

        static void UpperHalf(int inputNum)
        {
            for (var upperHalf = 1; upperHalf <= inputNum; upperHalf++)
            {
                for (var rolls = 1; rolls <= upperHalf; rolls++)
                {
                    Console.Write(rolls + " ");
                }

                Console.WriteLine();
            }
        }

        static void LowerHalf(int inputNum)
        {
            for (var lowerHalf =inputNum- 1; lowerHalf >= 1; lowerHalf--)
            {
                for (var rolls = 1; rolls <= lowerHalf; rolls++)
                {
                    Console.Write(rolls + " ");
                }

                Console.WriteLine();
            }
        }

        static void PrintingTriangle(int inputNum)
        {
            UpperHalf(inputNum);
            LowerHalf(inputNum);
        }
    }
}
