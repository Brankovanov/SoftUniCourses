using System;
using System.Linq;

namespace Ex_06_JaggedArrManipulation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveRolls();
        }

        private static void ReceiveRolls()
        {
            var rows = int.Parse(Console.ReadLine());

            PopulateMatrix(rows);
        }

        private static void PopulateMatrix(int rows)
        {
            var matrix = new double[rows][];

            for (var r = 0; r < rows; r++)
            {
                var t = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n)).ToArray();
                matrix[r] = t;
            }

            AnalizeMatrix(matrix, rows);
            ManipulateMatrix(matrix, rows);
        }

        private static void ManipulateMatrix(double[][] matrix, int rows)
        {
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var row = 0;
            var column = 0;
            var value = 0;

            while (command[0] != "End")
            {
                var rowCheck = int.TryParse(command[1], out row);
                var columnCheck = int.TryParse(command[2], out column);
                var valueCheck = int.TryParse(command[3], out value);

                if (row >= 0 && row < rows && column >= 0 && column < matrix[row].Length 
                    && rowCheck == true&& valueCheck==true && columnCheck==true)
                {
                    switch (command[0])
                    {
                        case "Add":
                            Add(row, column, value, matrix);
                            break;

                        case "Subtract":
                            Subtract(row, column, value, matrix);
                            break;
                    }
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Print(matrix, rows);
        }

        private static void Print(double[][] matrix, int rows)
        {
            for (var row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(' ', matrix[row]));
            }
        }

        private static void Subtract(int row, int column, int value, double[][] matrix)
        {
            matrix[row][column] -= value;
        }

        private static void Add(int row, int column, int value, double[][] matrix)
        {
            matrix[row][column] += value;
        }

        private static void AnalizeMatrix(double[][] matrix, int rows)
        {
            for (var r = 0; r < rows; r++)
            {
                if (r + 1 < rows && matrix[r].Length == matrix[r + 1].Length)
                {
                    matrix[r] = matrix[r].Select(n => n * 2).ToArray();
                    matrix[r + 1] = matrix[r + 1].Select(n => n * 2).ToArray();
                }
                else if (r + 1 < rows && matrix[r].Length != matrix[r + 1].Length)
                {
                    matrix[r] = matrix[r].Select(n => n / 2).ToArray();
                    matrix[r + 1] = matrix[r + 1].Select(n => n / 2).ToArray();
                }
            }
        }
    }
}