using System;
using System.Linq;

namespace Exercise_02_DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main(string[] args)
        {
            ReceiveMatrixParameters();
        }

        //Receive matrix parameters.
        static void ReceiveMatrixParameters()
        {
            var parameters = int.Parse(Console.ReadLine());
            var matrix = new int[parameters][];

            for (var r = 0; r < parameters; r++)
            {
                var row = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x.Trim())).ToArray();               
                CreateMatrix(row, matrix, r);
            }

            CalculateDiagonals(matrix);
        }

        //Creates new matrix.
        static void CreateMatrix(int[] row, int[][] matrix, int r)
        {
            matrix[r] = new int[row.Length];
            matrix[r] = row;
        }

        //Calculate diagonals.
        static void CalculateDiagonals(int[][]matrix)
        {
            var diagonalOne = 0;
            var diagonalTwo = 0;
            var indexTwo = matrix.Length-1;

            for (var r = 0; r < matrix.Length; r++)
            {
                diagonalOne += matrix[r][r];
                diagonalTwo += matrix[r][indexTwo];
                indexTwo--;
            }

            var absoluteDifference = Math.Abs(diagonalTwo - diagonalOne);
            PrintDifference(absoluteDifference);
        }

        //Prints the absolute difference between the two diagonals.
        static void PrintDifference(int absoluteDifference)
        {
            Console.WriteLine(absoluteDifference);
        }
    }
}