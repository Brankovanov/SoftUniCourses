using System;
using System.Linq;

namespace Exercise_08_RadioactiveBunnies
{
    public class RadioactiveBunnies
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var lairDimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var lairRows = lairDimentions[0];
            var lairCols = lairDimentions[1];

            CreateLair(lairRows, lairCols);
        }

        //Creates the lair.
        static void CreateLair(int lairRows, int lairCols)
        {
            var lair = new char[lairRows][];
            Player newPlayer = new Player();

            for (var row = 0; row < lairRows; row++)
            {
                var lairParts = Console.ReadLine().ToCharArray();

                if (lairParts.Contains('P'))
                {
                    newPlayer.PlayerRow = row;
                    newPlayer.PlayerCol = lairParts.ToList().IndexOf('P');
                    newPlayer.GameResult = string.Empty;
                }

                lair[row] = lairParts;
            }

            var commands = Console.ReadLine().ToCharArray();
            ExecuteCommands(lair, commands, newPlayer);
        }

        //Executes the commands received.
        static void ExecuteCommands(char[][] lair, char[] commands, Player newPlayer)
        {
            foreach (var com in commands)
            {  
                switch (com)
                {
                    case 'U':
                        MoveUp(newPlayer, lair);
                        break;
                    case 'D':
                        MoveDown(newPlayer, lair);
                        break;
                    case 'L':
                        MoveLeft(newPlayer, lair);
                        break;
                    case 'R':
                        MoveRight(newPlayer, lair);
                        break;
                }

                SpreadTheBunnies(lair, newPlayer);
                CheckResult(lair, newPlayer);
            }
        }

        //Moves the player right.
        static void MoveRight(Player newPlayer, char[][] lair)
        {
            if (newPlayer.PlayerCol + 1 < lair[newPlayer.PlayerRow].Length && lair[newPlayer.PlayerRow][newPlayer.PlayerCol + 1] == '.')
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol + 1] = 'P';
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.PlayerCol++;
            }
            else if (newPlayer.PlayerCol + 1 < lair[newPlayer.PlayerRow].Length && lair[newPlayer.PlayerRow][newPlayer.PlayerCol + 1] == 'B')
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "dead: ";
                newPlayer.PlayerCol++;
            }
            else if (newPlayer.PlayerCol + 1 == lair[newPlayer.PlayerRow].Length)
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "won: ";
            }
        }

        //Moves the player left.
        static void MoveLeft(Player newPlayer, char[][] lair)
        {
            if (newPlayer.PlayerCol - 1 >= 0 && lair[newPlayer.PlayerRow][newPlayer.PlayerCol - 1] == '.')
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol - 1] = 'P';
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.PlayerCol--;
            }
            else if (newPlayer.PlayerCol - 1 >= 0 && lair[newPlayer.PlayerRow][newPlayer.PlayerCol - 1] == 'B')
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "dead: ";
                newPlayer.PlayerCol--;
            }
            else if (newPlayer.PlayerCol - 1 < 0)
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "won: ";
            }
        }

        //Moves the player up.
        static void MoveUp(Player newPlayer, char[][] lair)
        {
            if (newPlayer.PlayerRow - 1 >= 0 && lair[newPlayer.PlayerRow - 1][newPlayer.PlayerCol] == '.')
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                lair[newPlayer.PlayerRow - 1][newPlayer.PlayerCol] = 'P';
                newPlayer.PlayerRow--;
            }
            else if (newPlayer.PlayerRow - 1 >= 0 && lair[newPlayer.PlayerRow - 1][newPlayer.PlayerCol] == 'B')
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "dead: ";
                newPlayer.PlayerRow--;
            }
            else if (newPlayer.PlayerRow - 1 < 0)
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "won: ";
            }
        }

        //Moves the player down.
        static void MoveDown(Player newPlayer, char[][] lair)
        {
            if (newPlayer.PlayerRow + 1 < lair.Length && lair[newPlayer.PlayerRow + 1][newPlayer.PlayerCol] == '.')
            {
                lair[newPlayer.PlayerRow + 1][newPlayer.PlayerCol] = 'P';
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.PlayerRow++;
            }
            else if (newPlayer.PlayerRow + 1 < lair.Length && lair[newPlayer.PlayerRow + 1][newPlayer.PlayerCol] == 'B')
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "dead: ";
                newPlayer.PlayerRow++;
            }
            else if (newPlayer.PlayerRow + 1 == lair.Length)
            {
                lair[newPlayer.PlayerRow][newPlayer.PlayerCol] = '.';
                newPlayer.GameResult = "won: ";
            }
        }

        //Spreads the bunnies after the players move.
        static void SpreadTheBunnies(char[][] lair, Player newPlayer)
        {
            for (var row = 0; row < lair.Length; row++)
            {
                for (var cell = 0; cell < lair[row].Length; cell++)
                {
                    if (lair[row][cell] == 'B')
                    {
                        if (row - 1 >= 0 && lair[row - 1][cell] == '.')
                        {
                            lair[row - 1][cell] = 'X';
                        }
                        else if (row - 1 >= 0 && lair[row - 1][cell] == 'P')
                        {
                            lair[row - 1][cell] = 'X';
                            newPlayer.GameResult = "dead: ";
                        }

                        if (cell - 1 >= 0 && lair[row][cell - 1] == '.')
                        {
                            lair[row][cell - 1] = 'X';
                        }
                        else if (cell - 1 >= 0 && lair[row][cell - 1] == 'P')
                        {
                            lair[row][cell - 1] = 'X';
                            newPlayer.GameResult = "dead: ";
                        }

                        if (row + 1 < lair.Length && lair[row + 1][cell] == '.')
                        {
                            lair[row + 1][cell] = 'X';
                        }
                        else if (row + 1 < lair.Length && lair[row + 1][cell] == 'P')
                        {
                            lair[row + 1][cell] = 'X';
                            newPlayer.GameResult = "dead: ";
                        }

                        if (cell + 1 < lair[row].Length && lair[row][cell + 1] == '.')
                        {
                            lair[row][cell + 1] = 'X';                          
                        }
                        else if (cell + 1 < lair[row].Length && lair[row][cell + 1] == 'P')
                        {
                            lair[row][cell + 1] = 'X';
                            newPlayer.GameResult = "dead: ";
                        }
                    }
                }
            }

            for (var r = 0; r < lair.Length; r++)
            {
                for (var x = 0; x < lair[r].Length; x++)
                {
                    if (lair[r][x]=='X')
                    {
                        lair[r][x] = 'B'; 
                    }
                }
            }
        }

        //Checks the result after the end of the turn.
        static void CheckResult(char[][] lair, Player newPlayer)
        {
            if (newPlayer.GameResult != string.Empty)
            {
                PrintResult(lair, newPlayer);
            }
            else
            {
               return;
            }
        }

        //Prints the final result of the game on the console.
        static void PrintResult(char[][] lair, Player newPlayer)
        {
            foreach (var r in lair)
            {
                Console.WriteLine(string.Join(string.Empty, r));
            }

            Console.WriteLine(newPlayer.GameResult + newPlayer.PlayerRow + " " + newPlayer.PlayerCol);
            Environment.Exit(0);
        }
    }

    //Creates object newPlayer that holds the player coordinates and the game result.
    public class Player
    {
        private string gameResult;
        private int playerRow;
        private int playerCol;

        public string GameResult
        {
            get
            {
                return this.gameResult;
            }
            set
            {
                this.gameResult = value;
            }
        }

        public int PlayerRow
        {
            get
            {
                return this.playerRow;
            }
            set
            {
                this.playerRow = value;
            }
        }

        public int PlayerCol
        {
            get
            {
                return this.playerCol;
            }
            set
            {
                this.playerCol = value;
            }
        }

        public Player()
        {
            this.gameResult = GameResult;
            this.playerRow = PlayerRow;
            this.playerCol = PlayerCol;
        }
    }
}