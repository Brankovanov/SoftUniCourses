using System;
using System.Linq;

namespace Ex_02_SquaresInMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        private static void ReceiveDimentions()
        {
            var dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            CreateMatrix(dimentions);
        }

        private static void CreateMatrix(int[] dimentions)
        {
            var rows = dimentions[0];
            var columns = dimentions[1];
            var matrix = new string[rows, columns];

            FillTheMatrix(matrix, rows, columns);

            FindSubMatrixSquares(matrix, rows, columns);
        }

        private static void FillTheMatrix(string[,] matrix, int rows, int columns)
        {
            for (var row = 0; row < rows; row++)
            {
                var rowElements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

                for (var column = 0; column < columns; column++)
                {
                    matrix[row, column] = rowElements[column];
                }
            }
        }

        private static void FindSubMatrixSquares(string[,] matrix, int rows, int columns)
        {
            var counter = 0;

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    if ((row + 1 < rows && column + 1 < columns) &&
                        (matrix[row, column]== matrix[row, column + 1]) && 
                        (matrix[row, column] == matrix[row + 1, column]) && 
                        (matrix[row, column] == matrix[row + 1, column + 1]))
                    {
                        counter++;                      
                    }
                }
            }

            Print(counter);
        }

        private static void Print(int counter)
        {
            Console.WriteLine(counter);
        }
    }
}