using System;
using System.Linq;

namespace Ex_04_MatrixShuffling
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        private static void ReceiveDimentions()
        {
            var dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            CreateMatrix(dimentions);
        }

        private static void CreateMatrix(int[] dimentions)
        {
            var rows = dimentions[0];
            var columns = dimentions[1];

            var matrix = new string[rows, columns];


            FillTheMatrix(matrix, rows, columns);

            ManipulateMatrix(matrix, rows, columns);
        }

        private static void FillTheMatrix(string[,] matrix, int rows, int columns)
        {
            for (var row = 0; row < rows; row++)
            {
                var rowElements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (var column = 0; column < columns; column++)
                {
                    matrix[row, column] = rowElements[column];
                }
            }
        }

        private static void ManipulateMatrix(string[,] matrix, int rows, int columns)
        {

            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            while (command[0] != "END")
            {

              

                if (command[0] == "swap" &&
                    command.Length == 5 &&
                    int.Parse(command[1]) < rows && int.Parse(command[1]) >= 0 &&
                    int.Parse(command[3]) < rows && int.Parse(command[3]) >= 0 &&
                    int.Parse(command[2]) < columns && int.Parse(command[2]) >= 0 &&
                    int.Parse(command[4]) < columns && int.Parse(command[4]) >= 0)
                {
                    Swap(matrix, int.Parse(command[1]), int.Parse(command[2]), int.Parse(command[3]), int.Parse(command[4]));
                    Print(matrix, rows, columns);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
            }


        }

        private static void Swap(string[,] matrix, int rowOne, int colOne, int rowTwo, int colTwo)
        {
            var temp = matrix[rowOne, colOne];
            matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
            matrix[rowTwo, colTwo] = temp;

        }


        private static void Print(string[,] matrix, int rows, int columns)
        {
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
