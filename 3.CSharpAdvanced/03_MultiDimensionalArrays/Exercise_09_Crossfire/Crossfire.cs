using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_09_Crossfire
{
    public class Crossfire
    {
        public static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        //Receives the dimentions of the matrix from the console.
        static void ReceiveDimentions()
        {
            var dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];
            CreateMatrix(rows, cols);
        }

        //Creates and fills the matrix.
        static void CreateMatrix(int rows, int cols)
        {
            var matrix = new string[rows][];
            var n = 1;

            for (var row = 0; row < rows; row++)
            {
                matrix[row] = new string[cols];

                for (var col = 0; col < cols; col++)
                {
                    matrix[row][col] = n.ToString();
                    n++;
                }
            }

            ReceiveComments(matrix, cols);
        }

        //Receives commands from the console.
        static void ReceiveComments(string[][] matrix, int cols)
        {
            var command = Console.ReadLine();

            while (!command.Equals("Nuke it from orbit"))
            {
                var commands = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x.ToString())).ToArray();
                var r = commands[0];
                var c = commands[1];
                var radius = commands[2];

                ExecuteCommands(r, c, radius, matrix);
                Crumble(matrix, cols);

                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        //Execute the received commands.
        static void ExecuteCommands(int r, int c, int radius, string[][] matrix)
        {
            if ((r >= 0 && r < matrix.Length) && (c >= 0 && c < matrix[r].Length))
            {
                TargetInsideTheMatrix(r, c, radius, matrix);
            }
            else if ((r < 0 || r >= matrix.Length) || (c < 0 || c >= matrix[0].Length))
            {
                TargetOutsideTheMatrix(r, c, radius, matrix);
            }
        }

        //Activates if the targeted position is inside the matrix.
        static void TargetInsideTheMatrix(int r, int c, int radius, string[][] matrix)
        {
            matrix[r][c] = string.Empty;

            if (r - radius >= 0)
            {
                for (var distance = 1; distance <= radius; distance++)
                {
                    matrix[r - distance][c] = string.Empty;
                }
            }
            else if (r - radius < 0)
            {
                for (var distance = 1; distance <= r; distance++)
                {
                    matrix[r - distance][c] = string.Empty;
                }
            }

            if (r + radius < matrix.Length)
            {
                for (var distance = 1; distance <= radius; distance++)
                {
                    matrix[r + distance][c] = string.Empty;
                }
            }
            else if (r + radius >= matrix.Length)
            {
                for (var distance = 1; distance < matrix.Length - r; distance++)
                {
                    matrix[r + distance][c] = string.Empty;
                }
            }

            if (c - radius >= 0)
            {
                for (var distance = 1; distance <= radius; distance++)
                {
                    matrix[r][c - distance] = string.Empty;
                }
            }
            else if (c - radius < 0)
            {
                for (var distance = 1; distance <= c; distance++)
                {
                    matrix[r][c - distance] = string.Empty;
                }
            }

            if (c + radius < matrix[r].Length)
            {
                for (var distance = 1; distance <= radius; distance++)
                {
                    matrix[r][c + distance] = string.Empty;
                }
            }
            else if (c + radius >= matrix[r].Length)
            {
                for (var distance = 1; distance < matrix[r].Length - c; distance++)
                {
                    matrix[r][c + distance] = string.Empty;
                }
            }
        }

        //Activates if the target is outside the matrix.
        static void TargetOutsideTheMatrix(int r, int c, int radius, string[][] matrix)
        {
            if (r < 0 && c >= 0 && c < matrix[0].Length && radius > Math.Abs(r) - 1)
            {
                ShotOverTheTarget(r, c, radius, matrix);
            }
            else if (r >= matrix.Length && c >= 0 && c < matrix[0].Length && radius > r - matrix.Length)
            {
                ShotBelowTheTarget(r, c, radius, matrix);
            }
            else if (c < 0 && r >= 0 && r < matrix.Length && radius > Math.Abs(c) - 1)
            {
                ShotLeftOfTheTarget(r, c, radius, matrix);
            }
            else if (c >= matrix[0].Length - 1 && r >= 0 && r < matrix.Length && radius > c - matrix[0].Length)
            {
                ShotRightOfTheTarget(r, c, radius, matrix);
            }
        }

        //Activates when the shot is over the target.
        static void ShotOverTheTarget(int r, int c, int radius, string[][] matrix)
        {
            if (Math.Abs(radius - Math.Abs(r)) <= matrix.Length - 1)
            {
                for (var distance = 0; distance <= radius - Math.Abs(r); distance++)
                {
                    matrix[distance][c] = string.Empty;
                }
            }
            else
            {
                for (var distance = 0; distance <= matrix.Length - 1; distance++)
                {
                    matrix[distance][c] = string.Empty;
                }
            }
        }

        //Activates when the shot is below the target.
        static void ShotBelowTheTarget(int r, int c, int radius, string[][] matrix)
        {
            if (Math.Abs(radius - (r - matrix.Length)) <= matrix.Length - 1)
            {
                for (var distance = 0; distance < radius - (r - matrix.Length); distance++)
                {
                    matrix[matrix.Length - 1 - distance][c] = string.Empty;
                }
            }
            else
            {
                for (var distance = 0; distance <= matrix.Length - 1; distance++)
                {
                    matrix[matrix.Length - 1 - distance][c] = string.Empty;
                }
            }
        }

        //Activates when the shot is left from the target.
        static void ShotLeftOfTheTarget(int r, int c, int radius, string[][] matrix)
        {
            if (Math.Abs(radius - Math.Abs(c)) <= matrix[r].Length - 1)
            {
                for (var distance = 0; distance <= radius - Math.Abs(c); distance++)
                {
                    matrix[r][distance] = string.Empty;
                }
            }
            else
            {
                for (var distance = 0; distance <= matrix[r].Length - 1; distance++)
                {
                    matrix[r][distance] = string.Empty;
                }
            }
        }

        //Activates when the shot is right from the target.
        static void ShotRightOfTheTarget(int r, int c, int radius, string[][] matrix)
        {
            if (radius - Math.Abs(radius - c) <= matrix[r].Length - 1 && radius % 2 != 0)
            {
                for (var distance = 1; distance <= radius - Math.Abs(radius - c); distance++)
                {
                    matrix[r][matrix[r].Length - distance] = string.Empty;
                }
            }
            else if (radius - Math.Abs(radius - c) <= matrix[r].Length - 1 && radius % 2 == 0)
            {
                for (var distance = 1; distance <= radius - Math.Abs(radius - c + 1); distance++)
                {
                    matrix[r][matrix[r].Length - distance] = string.Empty;
                }
            }
            else
            {
                for (var distance = 0; distance <= matrix[r].Length - 1; distance++)
                {
                    matrix[r][matrix[r].Length - 1 - distance] = string.Empty;
                }
            }
        }

        //Crumbles the matrix.
        static void Crumble(string[][] matrix, int cols)
        {
            var lineMod = 0;

            for (var line = 0; line < matrix.Length; line++)
            {
                var index = 0;
                var tempQueue = new Queue<string>(matrix[line]);

                if (tempQueue.First() == string.Empty && tempQueue.Last() == string.Empty)
                {
                    lineMod++;
                }
                else
                {
                    matrix[line - lineMod] = new string[cols];

                    do
                    {
                        if (tempQueue.Peek() != string.Empty)
                        {
                            matrix[line - lineMod][index] = tempQueue.Dequeue();
                            index++;
                        }
                        else
                        {
                            tempQueue.Dequeue();
                        }
                    }
                    while (tempQueue.Count > 0);

                    index = 0;

                    if (lineMod > 0 && line == matrix.Length - 1)
                    {
                        matrix[matrix.Length - 1] = new string[cols];
                    }
                }
            }
        }

        //Prints the matrix after the las command.
        static void PrintMatrix(string[][] matrix)
        {
            foreach (var row in matrix)
            {
                if (row[0] != null)
                {
                    Console.WriteLine(string.Join(" ", row));
                }
            }
        }
    }
}