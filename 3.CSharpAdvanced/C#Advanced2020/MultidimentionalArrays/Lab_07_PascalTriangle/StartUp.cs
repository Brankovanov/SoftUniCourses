using System;

namespace Lab_07_PascalTriangle
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
            var matrix = new long[dimentions][];

            FillTheMatrix(matrix, dimentions);

            PrintResults(matrix,dimentions);
        }

        private static void FillTheMatrix(long[][] matrix, int dimentions)
        {
            for (var row = 0; row < dimentions; row++)
            {
                matrix[row] = new long[row + 1];

                for(var col=0; col<row+1;col++)
                {
                    if(col==0 || col==row)
                    {
                        matrix[row][col] = 1;
                    }
                    else 
                    {
                        matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
                    }                  
                }
            }
        }

        private static void PrintResults(long[][] matrix, int dimentions)
        {
            for (var row = 0; row < dimentions; row++)
            {
                for (var column = 0; column < row+1; column++)
                {
                    Console.Write(matrix[row][column]+ " ");
                }

                Console.WriteLine(); 
            }
        }
    }
}