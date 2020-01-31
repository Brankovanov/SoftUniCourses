using System;
using System.Linq;

namespace Ex_01_DigonalDifference
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
            var matrix = new int[dimentions][];

            CreateMatrix(dimentions,matrix);
            CalculateDiagonal(matrix,dimentions);
        }

        private static void CreateMatrix(int dimentions, int[][] matrix)
        {

            var entry = new int[dimentions];

            for (var row = 0; row < dimentions; row++)
            {
                entry = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

                matrix[row] = entry;
            }
        }

        private static void CalculateDiagonal(int[][] matrix, int dimentions)
        {
            var primaryDiagonal = 0;
            var secondaryDiagonal = 0;

            for(var row = 0; row<dimentions;row++)
            {
                primaryDiagonal += matrix[row][row];
                secondaryDiagonal += matrix[row][dimentions - 1 - row];
            }

            CalculateDiagonalDifference(primaryDiagonal, secondaryDiagonal);
        }

        private static void CalculateDiagonalDifference(int primaryDiagonal, int secondaryDiagonal)
        {
            var diff = Math.Abs(primaryDiagonal - secondaryDiagonal);

            PrintDifference(diff);
        }

        private static void PrintDifference(int diff)
        {
            Console.WriteLine(diff);
        }     
    }
}