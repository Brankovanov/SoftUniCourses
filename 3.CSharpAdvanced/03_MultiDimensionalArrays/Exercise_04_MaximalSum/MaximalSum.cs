using System;
using System.Linq;

namespace Exercise_04_MaximalSum
{
    public class MaximalSum
    {
        public static void Main(string[] args)
        {
            ReceiveMatrixDimentions();
        }

        //Receives the dimentions of the matrix from the console.
        static void ReceiveMatrixDimentions()
        {
            var matrixDimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x.Trim())).ToArray();
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
                var row = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x.Trim())).ToArray();
                matrix[r] = row;
            }

            SearchBiggestSubMatrix(matrix);
        }

        //Searches for the biggest submatrix.
        static void SearchBiggestSubMatrix(int[][] matrix)
        {
            var tempMatrix = new int[3][];
            var maxSubMatrix = new int[3][];
            var tempSum = 0;
            var maxSum = 0;
            var modC = 0;
            var modR = 0;

            while ((2 + modR) < matrix.Length)
            {
                if ((2 + modC) < matrix[0].Length)
                {
                    for (var roll = 0; roll < 3; roll++)
                    {
                        tempMatrix[roll] = new int[3];

                        for (var column = 0; column < 3; column++)
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

                        for (var r = 0; r < 3; r++)
                        {
                            maxSubMatrix[r] = new int[3];

                            for (var n = 0; n < 3; n++)
                            {
                                maxSubMatrix[r][n] = tempMatrix[r][n];
                            }
                        }
                    }
                    else if(maxSum >= tempSum)
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
            Console.WriteLine("Sum = " + maxSum);

            foreach (var row in maxSubMatrix)
            {
                try
                {
                    foreach (var n in row)
                    {
                        Console.Write(n + " ");
                    }

                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("0 0 0");
                }   
            }     
        }
    }
}