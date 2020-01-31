using System;
using System.Linq;

namespace Lab_06_MatrixManipulation
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

            ManipulateMatrix(matrix, rows, columns);
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

        private static void ManipulateMatrix(int[,] matrix, int rows, int columns)
        {
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
            

            while (command[0] != "END")
            {
                var row = int.Parse(command[1]);
                var col = int.Parse(command[2]);
                var value = int.Parse(command[3]);

                if (row >= 0 && row < rows && col >= 0 && col < columns)
                {
                    switch (command[0])
                    {
                        case "Add":
                            Add(matrix, row, col, value);
                            break;

                        case "Subtract":
                            Subtract(matrix, row, col, value);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
            }

            Print(matrix, rows, columns);
        }

        private static void Subtract(int[,] matrix, int row, int col, int value)
        {
            matrix[row, col] -= value;
        }

        private static void Add(int[,] matrix, int row, int col, int value)
        {
            matrix[row, col] += value;
        }

        private static void Print(int[,] matrix, int rows, int columns)
        {
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                   Console.Write(matrix[row, column]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}