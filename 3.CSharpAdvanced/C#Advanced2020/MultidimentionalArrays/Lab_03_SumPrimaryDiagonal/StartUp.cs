using System;
using System.Linq;

namespace Lab_03_SumPrimaryDiagonal
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        private static void ReceiveDimentions()
        {
            var dimentions = int.Parse(Console.ReadLine());

            CreateMatrix(dimentions);
        }

        private static void CreateMatrix(int dimentions)
        {
            var rows = dimentions;
            var columns = dimentions;

            var matrix = new int[rows, columns];


            FillTheMatrix(matrix, rows, columns);

            PrintResults(matrix, rows);
        }

        private static void PrintResults(int[,] matrix, int rows)
        {
            Console.WriteLine(CalculateSum(matrix, rows));
        }

        private static int CalculateSum(int[,] matrix, int rows)
        {
            var temp = 0;
            var column = 0;

            for (var row = 0; row < rows; row++)
            {
                temp += matrix[row, column];
                column++;
            }

            return temp;
        }

        private static void FillTheMatrix(int[,] matrix, int rows, int columns)
        {
            for (var row = 0; row < rows; row++)
            {
                var rowElements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

                for (var column = 0; column < columns; column++)
                {
                    matrix[row, column] = rowElements[column];
                }
            }
        }
    }
}
