using System;
using System.Linq;

namespace Lab_05_BiggestSubMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        private static void ReceiveDimentions()
        {
            var dimentions = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            CreateMatrix(dimentions);
        }

        private static void CreateMatrix(int[] dimentions)
        {
            var rows = dimentions[0];
            var columns = dimentions[1];
            var matrix = new int[rows, columns];

            FillTheMatrix(matrix, rows, columns);

            FindBiggestSubMatrix(matrix, rows, columns);
        }

        private static void FillTheMatrix(int[,] matrix, int rows, int columns)
        {
            for (var row = 0; row < rows; row++)
            {
                var rowElements = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

                for (var column = 0; column < columns; column++)
                {
                    matrix[row, column] = rowElements[column];
                }
            }
        }

        private static void FindBiggestSubMatrix(int[,] matrix, int rows, int columns)
        {
            var biggestSubMatrix = 0;
            var temp = 0;
            var sub = new int[2, 2];

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    if (row + 1 < rows && column + 1 < columns)
                    {
                        temp = matrix[row, column] + matrix[row, column + 1] +
                            matrix[row + 1, column] + matrix[row + 1, column + 1];

                        if (temp > biggestSubMatrix)
                        {
                            biggestSubMatrix = temp;

                            sub[0, 0] = matrix[row, column];
                            sub[0, 1] = matrix[row, column + 1];
                            sub[1, 0] = matrix[row + 1, column];
                            sub[1, 1] = matrix[row +1, column + 1];

                        }
                    }
                }
            }

            Print(sub, biggestSubMatrix);
        }

        private static void Print(int[,] sub, int biggestSubMatrix)
        {
            for (var row = 0; row < 2; row++)
            {
                for (var column = 0; column < 2; column++)
                {
                    Console.Write(sub[row, column] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(biggestSubMatrix);
        }
    }
}
