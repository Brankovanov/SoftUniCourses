using System;
using System.Linq;

namespace Lab_02_MaximumSumSubMatrix
{
    public class MaximumSumSubMatrix
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

            SearchBiggestSubMatrix(matrix);
        }

        //Searches for the biggest submatrix.
        static void SearchBiggestSubMatrix(int[][] matrix)
        {
            var tempMatrix = new int[2][];
            var maxSubMatrix = new int[2][];
            var tempSum = 0;
            var maxSum = 0;
            var modC = 0;
            var modR = 0;

            while ((1 + modR) < matrix.Length)
            {
                if ((1 + modC) < matrix[0].Length)
                {
                    for (var roll = 0; roll < 2; roll++)
                    {
                        tempMatrix[roll] = new int[2];
                        for (var column = 0; column < 2; column++)
                        {
                            tempMatrix[roll][column] = matrix[roll + modR][column + modC];
                        }
                    }

                    modC++;

                    foreach (var r in tempMatrix)
                    {
                        foreach (var n in r)
                        {
                            tempSum += n;
                        }
                    }

                    if (maxSum < tempSum)
                    {
                        maxSum = tempSum;
                        tempSum = 0;

                        for (var r = 0; r < 2; r++)
                        {
                            maxSubMatrix[r] = new int[2];

                            for (var n = 0; n < 2; n++)
                            {
                                maxSubMatrix[r][n] = tempMatrix[r][n];
                            }
                        }
                    }
                    else
                    {
                        tempSum = 0;
                    }
                }
                else
                {
                    modC = 0;
                    modR++;
                }
            }

            Print(maxSum, maxSubMatrix);
        }

        static void Print(int maxSum, int[][] maxSubMatrix)
        {
            foreach (var row in maxSubMatrix)
            {
                foreach (var n in row)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}