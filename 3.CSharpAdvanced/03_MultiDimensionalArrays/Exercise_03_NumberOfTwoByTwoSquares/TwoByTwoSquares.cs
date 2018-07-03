using System;
using System.Linq;

namespace Exercise_03_NumberOfTwoByTwoSquares
{
    public class TwoByTwoSquares
    {
        public static void Main(string[] args)
        {
            ReceiveMatrixDimentions();
        }

        //Receives the dimentions of the matrix from the console.
        static void ReceiveMatrixDimentions()
        {
            var matrixDimentions = Console.ReadLine().Split(' ').Select(x => int.Parse(x.Trim())).ToArray();
            var rows = matrixDimentions[0];
            var col = matrixDimentions[1];

            CreateMatrix(rows, col);
        }

        //Creates the matrix.
        static void CreateMatrix(int rows, int col)
        {
            var matrix = new string[rows][];

            for (var r = 0; r < rows; r++)
            {
                var row = Console.ReadLine().Split(' ').Select(x => x.Trim()).ToArray();
                matrix[r] = row;
            }

            SearchBiggestSubMatrix(matrix);
        }

        //Searches for the biggest submatrix.
        static void SearchBiggestSubMatrix(string[][] matrix)
        {
            var tempMatrix = new string[2][];
            var counter = 0;
            var count = 0;
            var modC = 0;
            var modR = 0;

            while ((1 + modR) < matrix.Length)
            {
                if ((1 + modC) < matrix[0].Length)
                {
                    for (var roll = 0; roll < 2; roll++)
                    {
                        tempMatrix[roll] = new string[2];

                        for (var column = 0; column < 2; column++)
                        {
                            tempMatrix[roll][column] = matrix[roll + modR][column + modC];
                        }
                    }

                    modC++;

                    var comparer = tempMatrix[0][0];

                    foreach (var r in tempMatrix)
                    {
                        for (var c = 0; c < r.Length; c++)
                        {
                            if (comparer.Equals(r[c]))
                            {
                                counter++;
                            }
                        }
                    }

                    if (counter == 4)
                    {
                        count++;
                    }

                    counter = 0;
                }
                else
                {
                    modC = 0;
                    modR++;
                }
            }

            Print(count);
        }

        static void Print(int count)
        {
            Console.WriteLine(count);
        }
    }
}