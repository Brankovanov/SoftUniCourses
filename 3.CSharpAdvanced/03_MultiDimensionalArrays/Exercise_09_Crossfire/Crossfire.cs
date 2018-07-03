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
            else if ((r < 0 || r >= matrix.Length) || (c < 0 && c >= matrix[r].Length))
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
            if (r < 0 && radius + r >= 0 && (c >= 0 && c < matrix[0].Length))
            {
                for (var distance = 0; distance <= radius + r; distance++)
                {
                    if (distance <= matrix.Length - 1)
                    {
                        matrix[distance][c] = string.Empty;
                    }
                    else
                    {
                    //    return;
                    }

                }
            }
            else if (c < 0 || c >= matrix[0].Length)
            {
              //  return;
            }

            if (r >= matrix.Length && r - matrix.Length - 1 < radius && (c >= 0 && c < matrix[0].Length))
            {
                for (var distance = 1; distance <= r - matrix.Length - 1; distance++)
                {
                    if (matrix.Length - distance >= 0)
                    {
                        matrix[matrix.Length - distance][c] = string.Empty;
                    }
                    else
                    {
                      //  return;
                    }
                }
            }
            else if (c < 0 || c >= matrix[0].Length)
            {
               // return;
            }

            if ((r >= 0 && r < matrix.Length) && c < 0 && radius + c >= 0 )
            {
                for (var distance = 0; distance <= radius + c; distance++)
                {
                    if (distance <= matrix[r].Length - 1)
                    {
                        matrix[r][distance] = string.Empty;
                    }
                    else
                    {
                       // return;
                    }

                }
            }
            else if (r < 0 && r > matrix.Length)
            {
              //  return;
            }

            if((r >= 0 && r < matrix.Length) && c >= matrix[r].Length && c-matrix[r].Length-1<radius)
            {
                for (var distance = 1; distance <= c - matrix[r].Length - 1; distance++)
                {
                    if (matrix[r].Length - distance >= 0)
                    {
                        matrix[r][matrix.Length - distance] = string.Empty;
                    }
                    else
                    {
                       // return;
                    }
                }
            }
            else if (r < 0 && r > matrix.Length)
            {
                //return;
            }
        }

        //Crumbles the matrix.
        static void Crumble(string[][] matrix, int cols)
        {
            for (var line = 0; line < matrix.Length; line++)
            {
                var index = 0;
                var tempQueue = new Queue<string>(matrix[line]);
                matrix[line] = new string[cols];

                do
                {
                    if (tempQueue.Peek() != string.Empty)
                    {
                        matrix[line][index] = tempQueue.Dequeue();
                        index++;
                    }
                    else
                    {
                        tempQueue.Dequeue();
                    }
                }
                while (tempQueue.Count > 0);

                index = 0;
            }
        }

        //Prints the matrix after the las command.
        static void PrintMatrix(string[][] matrix)
        {
            foreach (var r in matrix)
            {
                Console.WriteLine(string.Join(" ", r));
            }
        }
    }
}