using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_RubicMatrix
{
    public class RubicMatrux
    {
        public static void Main(string[] args)
        {
            ReceiveMatrixDimentions();
        }

        //Receives matrix dimentions from the console.
        static void ReceiveMatrixDimentions()
        {
            var dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x.Trim())).ToArray();
            var rows = dimentions[0];
            var columns = dimentions[1];

            CreateMatrix(rows, columns);
        }

        //Creates the required matrix.
        static void CreateMatrix(int rows, int columns)
        {
            var matrix = new int[rows][];
            var number = 1;

            for (var row = 0; row < rows; row++)
            {
                matrix[row] = new int[columns];

                for (var column = 0; column < columns; column++)
                {
                    matrix[row][column] = number;
                    number++;
                }
            }

            RececeiveCommands(matrix);
        }

        //Receives commands from the console.
        static void RececeiveCommands(int[][] matrix)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (var com = 1; com <= numberOfCommands; com++)
            {
                var command = Console.ReadLine();
                ExecuteCommands(command, matrix);
            }

            RearengeMatrix(matrix);
        }

        //Executes the commands received from the console.
        static void ExecuteCommands(string command, int[][] matrix)
        {
            var split = command.Split(' ').ToArray();
            var dimention = int.Parse(split[0]);
            var direction = split[1];
            var distance = int.Parse(split[2]);

            if (distance > matrix[0].Length)
            {
                distance = distance % matrix[0].Length;
            }

            switch (direction)
            {
                case "left":
                    MoveLeft(matrix, dimention, distance);
                    break;
                case "right":
                    MoveRight(matrix, dimention, distance);
                    break;
                case "up":
                    MoveUp(matrix, dimention, distance);
                    break;
                case "down":
                    MoveDown(matrix, dimention, distance);
                    break;
            }
        }

        //Moves the given row of the matrix left.
        static void MoveLeft(int[][] matrix, int dimention, int distance)
        {
            var temp = new Queue<int>(matrix[dimention].ToArray());

            for (var count = 0; count < distance; count++)
            {
                temp.Enqueue(temp.Dequeue());
            }

            matrix[dimention] = temp.ToArray();
        }

        //Moves the given row of the matrix right.
        static void MoveRight(int[][] matrix, int dimention, int distance)
        {
            var temp = new Queue<int>(matrix[dimention].ToArray().Reverse());

            for (var count = 0; count < distance; count++)
            {
                temp.Enqueue(temp.Dequeue());
            }

            matrix[dimention] = temp.Reverse().ToArray();
        }

        //Move the given column up.
        static void MoveUp(int[][] matrix, int dimention, int distance)
        {
            var temp = new Queue<int>();

            foreach (var r in matrix)
            {
                temp.Enqueue(r[dimention]);
            }

            temp.Reverse();

            for (var count = 0; count < distance; count++)
            {
                temp.Enqueue(temp.Dequeue());
            }

            temp.Reverse();

            foreach (var r in matrix)
            {
                r[dimention] = temp.Dequeue();
            }
        }


        //Move the given column down.
        static void MoveDown(int[][] matrix, int dimention, int distance)
        {
            var temp = new Queue<int>();

            foreach (var r in matrix)
            {
                temp.Enqueue(r[dimention]);
            }

            var reversed = new Queue<int>(temp.Reverse());

            for (var count = 0; count < distance; count++)
            {
                reversed.Enqueue(reversed.Dequeue());
            }

            temp = new Queue<int>(reversed.Reverse());

            foreach (var r in matrix)
            {
                r[dimention] = temp.Dequeue();
            }
        }

        //Rearenging the matrix elements in ascending order.
        static void RearengeMatrix(int[][] matrix)
        {
            var checker = 1;

            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == checker)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (var r = 0; r < matrix.Length; r++)
                        {
                            if (matrix[r].Contains(checker))
                            {
                                var temp = matrix[r].ToList();
                                Console.WriteLine($"Swap ({row}, {col}) with ({r}, {temp.IndexOf(checker)})");
                                matrix[r][temp.IndexOf(checker)] = matrix[row][col];
                                matrix[row][col] = checker;
                            }
                        }
                    }

                    checker++;
                }
            }
        }
    }
}