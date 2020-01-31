using System;
using System.Linq;

namespace Ex_10_RadioactiveVampiraBunnies
{
    class StartUP
    {
        static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        private static void ReceiveDimentions()
        {
            var dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            CreateBunnyLair(dimentions);
        }

        private static void CreateBunnyLair(int[] dimentions)
        {
            var row = dimentions[0];
            var column = dimentions[1];

            var lair = new string[row, column];

            PopulateLair(lair, row, column);
        }

        private static void PopulateLair(string[,] lair, int row, int column)
        {
            var playerRow = 0;
            var playerCol = 0;

            for (var r = 0; r < row; r++)
            {
                var temp = Console.ReadLine().ToCharArray();

                for (var c = 0; c < column; c++)
                {
                    lair[r, c] = temp[c].ToString();

                    if (temp[c] == 'P')
                    {
                        playerRow = r;
                        playerCol = c;
                    }
                }
            }

            var commands = Console.ReadLine().ToCharArray();

            ExecuteCommands(commands, column, row, lair, playerCol, playerRow);
        }

        private static void ExecuteCommands(char[] commands, int column, int row, string[,] lair, int playerCol, int playerRow)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        if (playerCol - 1 >= 0 && lair[playerRow, playerCol - 1] != "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            playerCol = playerCol - 1;
                            lair[playerRow, playerCol] = "P";
                        }
                        else if (playerCol - 1 >= 0 && lair[playerRow, playerCol - 1] == "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {playerRow} {playerCol-1}");                          
                            Environment.Exit(1);
                        }
                        else
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"won: {playerRow} {playerCol}");
                            Environment.Exit(1);
                        }
                        break;

                    case 'R':
                        if (playerCol + 1 < column && lair[playerRow, playerCol + 1] != "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            playerCol = playerCol + 1;
                            lair[playerRow, playerCol] = "P";
                        }
                        else if (playerCol + 1 < column && lair[playerRow, playerCol + 1] == "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {playerRow} {playerCol+1}");
                            Environment.Exit(1);
                        }
                        else
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"won: {playerRow} {playerCol}");
                            Environment.Exit(1);
                        }
                        break;

                    case 'U':
                        if (playerRow - 1 >= 0 && lair[playerRow - 1, playerCol] != "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            playerRow = playerRow - 1;
                            lair[playerRow, playerCol] = "P";
                        }
                        else if (playerRow - 1 >= 0 && lair[playerRow - 1, playerCol] == "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {playerRow-1} {playerCol}");
                            Environment.Exit(1);
                        }
                        else
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"won: {playerRow} {playerCol}");
                            Environment.Exit(1);
                        }
                        break;

                    case 'D':
                        if (playerRow + 1 < row && lair[playerRow + 1, playerCol] != "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            playerRow = playerRow + 1;
                            lair[playerRow, playerCol] = "P";
                        }
                        else if (playerRow + 1 < row && lair[playerRow + 1, playerCol] == "B")
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {playerRow+1} {playerCol}");
                            Environment.Exit(1);
                        }
                        else
                        {
                            lair[playerRow, playerCol] = ".";
                            SpreadBunnies(lair, row, column);
                            Print(lair, row, column);
                            Console.WriteLine($"won: {playerRow} {playerCol}");
                            Environment.Exit(1);
                        }
                        break;
                }
              //  Print(lair, row, column);
                SpreadBunnies(lair, row, column);             
            }
        }

        private static void MatureBunnies(string[,] lair, int row, int column)
        {
            for (var r = 0; r < row; r++)
            {
                for (var c = 0; c < column; c++)
                {
                    if(lair[r, c]=="b")
                    {
                        lair[r, c] = "B";
                    }
                }
            }
        }

        private static void Print(string[,] lair, int row, int column)
        {
            MatureBunnies(lair, row, column);

            for (var r = 0; r < row; r++)
            {
                for (var c = 0; c < column; c++)
                {
                    Console.Write(lair[r, c]);
                }
                Console.WriteLine();
            }
        
        }

        private static void SpreadBunnies(string[,] lair, int row, int column)
        {
            for (var r = 0; r < row; r++)
            {
                for (var c = 0; c < column; c++)
                {
                    if (lair[r, c] == "B")
                    {

                        if ((r + 1 < row) &&
                            lair[r + 1, c] != "P")
                        {
                            lair[r + 1, c] = "b";
                        }
                        else if ((r + 1 < row) &&
                            lair[r + 1, c] == "P")
                        {
                            lair[r + 1, c] = "b";
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {r + 1} {c}");
                            Environment.Exit(1);
                        }

                        if ((r - 1 >= 0) &&
                            lair[r - 1, c] != "P")
                        {
                            lair[r - 1, c] = "b";
                        }
                        else if ((r - 1 > 0) &&
                            lair[r - 1, c] == "P")
                        {
                            lair[r - 1, c] = "B";
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {r - 1} {c}");
                            Environment.Exit(1);
                        }

                        if ((c + 1 < column) &&
                           lair[r, c + 1] != "P")
                        {
                            lair[r, c + 1] = "b";
                        }
                        else if ((c + 1 < column) &&
                           lair[r, c + 1] == "P")
                        {
                            lair[r, c + 1] = "B";
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {r } {c + 1}");
                            Environment.Exit(1);
                        }

                        if ((c - 1 >= 0) &&
                          lair[r, c - 1] != "P")
                        {
                            lair[r, c - 1] = "b";
                        }
                        else if ((c - 1 >= 0) &&
                          lair[r, c - 1] == "P")
                        {
                            lair[r, c - 1] = "B";
                            Print(lair, row, column);
                            Console.WriteLine($"dead: {r } {c - 1}");
                            Environment.Exit(1);
                        }

                    }
                }
            }

            MatureBunnies(lair, row, column);
        }
    }
}
