using System;
using System.Linq;

namespace Lab_01_SumMatrixElements
{
    public class SumMatrixElements
    {
        public static void Main(string[] args)
        {
            ReceiveMatrixDimentions();
        }

        //Receives the dimentions of the matrix from the console.
        static void ReceiveMatrixDimentions()
        {
            var matrixDimentions = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            var rows = matrixDimentions[0];
            var col = matrixDimentions[1];

            CreateMatrix(rows, col);
        }

        //Creates the matrix.
        static void CreateMatrix(int rows, int col)
        {
            var matrix = new int[rows][];

            for (var r = 0; r < rows; r++)
            {
                var row = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();

                matrix[r] = row;
            }

            CreateOutput(matrix);
        }

        //Calculates the output;
        static void CreateOutput(int[][]matrix)
        {
            var outputRows = matrix.Length;
            var outputColums = matrix[0].Length;
            var sum = 0;

            foreach(var n in matrix)
            {
                foreach(var x in n)
                {
                    sum += x;
                }
            }

            PrintOutput(outputRows, outputColums, sum);
        }

        //Prints the output on the console.
        static void PrintOutput(int outputRows,int outputColums, int sum)
        {
            Console.WriteLine(outputRows);
            Console.WriteLine(outputColums);
            Console.WriteLine(sum);
        }
    }
}