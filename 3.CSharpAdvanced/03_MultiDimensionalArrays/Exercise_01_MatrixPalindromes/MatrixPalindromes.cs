using System;
using System.Linq;

namespace Exercise_01_MatrixPalindromes
{
    public class MatrixPalindromes
    {
        public static void Main(string[] args)
        {
            ReceiveParameters();
        }

        //Receives the parameters of the matrix.
        static void ReceiveParameters()
        {
            var input = Console.ReadLine();
            CreateParameters(input);
        }

        //Creates parameters.
        static void CreateParameters(string input)
        {
            var temp = input.Split(' ').Select(x => int.Parse(x.Trim())).ToArray();
            var rows = temp[0];
            var columns = temp[1];
            CreateMatrix(rows, columns);
        }

        //Creates the matrix.
        static void CreateMatrix(int rows, int columns)
        {
            var startingChar = 'a';
            var middleChar = 'a';
            var endChar = startingChar;
            var entry = string.Empty;
            var matrix = new string[rows][];

            for (var r = 0; r < rows; r++)
            {
                matrix[r] = new string[columns];

                for (var c = 0; c < columns; c++)
                {
                    entry = (startingChar).ToString() + (middleChar).ToString() + (endChar).ToString();
                    matrix[r][c] = entry;
                    middleChar = (char)(1 + (int)middleChar);
                }

                startingChar = (char)(1 + (int)startingChar);
                middleChar = startingChar;
                endChar = startingChar;
            }

            PrintMatrix(matrix);
        }

        //Prints the final matrix.
        static void PrintMatrix(string[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var str in row)
                {
                    Console.Write(str + " ");
                }

                Console.WriteLine();
            }
        }
    }
}