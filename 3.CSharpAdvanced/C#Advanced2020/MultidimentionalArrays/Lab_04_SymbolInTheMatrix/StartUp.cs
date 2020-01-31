using System;

namespace Lab_04_SymbolInTheMatrix
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

            var matrix = new char[rows,columns];


            FillTheMatrix(matrix, rows, columns);

            FindElement(matrix, rows, columns);
        }

        private static void FillTheMatrix(char[,] matrix, int rows, int columns)
        {
            for (var row = 0; row < rows; row++)
            {
                var rowElements = Console.ReadLine().ToCharArray();

                for (var column = 0; column < columns; column++)
                {
                    matrix[row,column] = rowElements[column];
                }
            }
        }

        private static void FindElement(char[,] matrix, int rows, int columns)
        {
            var elementToFind = Console.ReadLine();

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    if (matrix[row,column].ToString() == elementToFind)
                    {
                        Console.WriteLine($"({row}, {column})");
                        Environment.Exit(1);
                    }
                }
            }

            Console.WriteLine($"{elementToFind} does not occur in the matrix");
        }
    }
}
