using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_TargetPractice
{
    public class TargetPractice
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var dimentions = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var snake = Console.ReadLine();
            var blastDimentions = Console.ReadLine().Split(' ').Select(y => int.Parse(y)).ToArray();

            GoingUp(dimentions, snake, blastDimentions);
        }

        //Creates the snakes going up the stairs.
        static void GoingUp(int[] dimentions, string snake, int[] blastDimentions)
        {
            var strRows = dimentions[0];
            var strCols = dimentions[1];
            var stairs = new char[strRows][];
            var stairsArea = strRows * strCols;
            var snakes = new Queue<char>();

            while (snakes.Count < stairsArea)
            {
                foreach (var ch in snake)
                {
                    snakes.Enqueue(ch);
                }
            }

            for (var row = 0; row < strRows; row++)
            {
                stairs[strRows - 1 - row] = new char[strCols];

                if ((row + 1) % 2 != 0)
                {
                    for (var cols = strCols - 1; cols >= 0; cols--)
                    {
                        stairs[strRows - 1 - row][cols] = snakes.Dequeue();
                    }
                }
                else if ((row + 1) % 2 == 0)
                {
                    for (var cols = 0; cols < strCols; cols++)
                    {
                        stairs[strRows - 1 - row][cols] = snakes.Dequeue();
                    }
                }
            }

            CalculateBlast(blastDimentions, stairs);
        }

        //Calculates where the blast hits.
        static void CalculateBlast(int[] blastDimentions, char[][] stairs)
        {
            var blastRow = blastDimentions[0];
            var blastColumn = blastDimentions[1];
            var blastRadius = blastDimentions[2];
            var upperBlast = blastRow + blastRadius;

            for (int row = 0; row < stairs.Length; row++)
            {
                for (int col = 0; col < stairs[row].Length; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - blastRow, 2) + Math.Pow(col - blastColumn, 2));

                    if (distance <= blastRadius)
                    {
                        stairs[row][col] = ' ';
                    }
                }
            }

            CrumbleRemains(stairs);
        }

        //Crumble the remnants after the blast.
        static void CrumbleRemains(char[][] stairs)
        {
            for (var row = stairs.Length - 1; row > 0; row--)
            {
                for (var column = 0; column < stairs[row].Length; column++)
                {
                    if (stairs[row][column] == ' ' && stairs[row - 1][column] != ' ')
                    {
                        stairs[row][column] = stairs[row - 1][column];
                        stairs[row - 1][column] = ' ';
                    }
                    else if (stairs[row][column] == ' ' && stairs[row - 1][column] == ' ')
                    {
                        var n = 0;

                        while ((row - n) != 0)
                        {
                            n++;

                            if (stairs[row - n][column] != ' ')
                            {
                                stairs[row][column] = stairs[row - n][column];
                                stairs[row - n][column] = ' ';
                                n = 0;
                                break;
                            }
                        }
                    }
                }
            }

            PrintOutput(stairs);
        }

        //Prints the final result on the console.
        static void PrintOutput(char[][] stairs)
        {
            foreach (var stair in stairs)
            {
                Console.WriteLine(string.Join(string.Empty, stair));
            }
        }
    }
}