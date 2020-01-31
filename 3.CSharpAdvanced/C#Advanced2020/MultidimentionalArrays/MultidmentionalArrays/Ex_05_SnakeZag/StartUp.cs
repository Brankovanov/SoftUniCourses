using System;
using System.Linq;

namespace Ex_05_SnakeZag
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        private static void ReceiveDimentions()
        {
            var dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();
            var snake = Console.ReadLine();

            CreateMatrix(dimentions, snake);
        }

        private static void CreateMatrix(int[] dimentions, string snake)
        {
            var rows = dimentions[0];
            var columns = dimentions[1];

            var matrix = new char[rows][];

            MoveSnake(rows, columns, matrix, snake);
        }

        private static void MoveSnake(int rows, int columns, char[][] matrix, string snake)
        {
            var zigzag = string.Empty;
            var temp = 0;
            var addition = string.Empty;
            var reversed = string.Empty;

            for (var row = 0; row < rows; row++)
            {
               
                if (addition.Length == columns)
                {
                    addition += snake;

                    if (row % 2 != 0)
                    {
                        reversed = string.Join(null, addition.Reverse());
                        matrix[row] = reversed.ToCharArray();
                    }
                    else
                    {
                        matrix[row] = addition.ToCharArray();
                    }

                    addition = " ";
                }
                else if (addition.Length < columns)
                {
                    temp = columns - addition.Length;

                    if(snake.Length>=temp)
                    {
                        addition += snake + snake.Substring(0, temp);
                    }
                    else
                    {
                        while(snake.Length<temp)
                        {
                            temp = temp - snake.Length;
                        }
                        addition += snake + snake.Substring(0, temp);
                    }

                    if (row %2!= 0)
                    {
                        reversed = string.Join(null, addition.Reverse());
                        matrix[row] = reversed.ToCharArray();
                    }
                    else
                    {
                        matrix[row] = addition.ToCharArray();
                    }
                   
                    addition = snake.Substring(temp, snake.Length - temp);
                }
                else if (addition.Length > columns)
                {
                    temp = snake.Length - columns;
                    addition += snake.Substring(0, columns);

                    if (row %2!= 0)
                    {
                        reversed = string.Join(null, addition.Reverse());
                        matrix[row] = reversed.ToCharArray();
                    }
                    else
                    {
                        matrix[row] = addition.ToCharArray();
                    }
                  
                    addition = snake.Substring(temp, snake.Length - temp);
                }
            }

            Print(matrix, rows, columns);
        }

        private static void Print(char[][] matrix, int rows, int columns)
        {
            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < columns; c++)
                {
                    Console.Write(matrix[r][c]);
                }
                Console.WriteLine();
            }
        }
    }
}
