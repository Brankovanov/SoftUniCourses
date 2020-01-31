using System;
using System.Linq;

namespace Lab_01_SumMatrixElements
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

            PrintResults(matrix, rows, columns);
        }

        private static void PrintResults(int[,] matrix, int rows, int columns)
        {
            var sum = CalculateSum(matrix, rows, columns);

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sum);
        }

        private static int CalculateSum(int[,] matrix, int rows, int columns)
        {
            var temp = 0;

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    temp += matrix[row,column];
                }
            }

            return temp;
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
    }
}
