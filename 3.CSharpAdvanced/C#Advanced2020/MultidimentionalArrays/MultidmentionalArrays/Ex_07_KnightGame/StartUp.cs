using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_07_KnightGame
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveBoardDimentions();
        }

        private static void ReceiveBoardDimentions()
        {
            var dimentions = int.Parse(Console.ReadLine());
            CreateBoard(dimentions);
        }

        private static void CreateBoard(int dimentions)
        {
            var rows = dimentions;
            var colls = dimentions;

            var board = new char[rows][];

            PopulateBoard(board, rows, colls);
        }

        private static void PopulateBoard(char[][] board, int rows, int colls)
        {
            for (var row = 0; row < rows; row++)
            {
                var r = Console.ReadLine();

                board[row] = r.ToCharArray();
            }

            var counter = 0;
            PlayTheGame(board, rows, colls,counter);
        }

        private static void PlayTheGame(char[][] board, int rows, int colls,int counter)
        {
            var validAttacks = 0;          
            var attk = new Dictionary<int,List<int[]>>();

            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < colls; c++)
                {
                    if (board[r][c] == 'K')
                    {
                        if ((r + 2 >= 0 && r + 2 < rows) &&
                            (c + 1 >= 0 && c + 1 < colls) &&
                            board[r + 2][c + 1] == 'K')
                        {
                            validAttacks++;
                        }

                        if ((r + 2 >= 0 && r + 2 < rows) &&
                                (c - 1 >= 0 && c - 1 < colls) &&
                                board[r + 2][c - 1] == 'K')
                        {
                            validAttacks++;
                        }

                        if ((r - 2 >= 0 && r - 2 < rows) &&
                                (c - 1 >= 0 && c - 1 < colls) &&
                                board[r - 2][c - 1] == 'K')
                        {
                            validAttacks++;
                        }
                        if ((r - 2 >= 0 && r - 2 < rows) &&
                                (c + 1 >= 0 && c + 1 < colls) &&
                                board[r - 2][c + 1] == 'K')
                        {
                            validAttacks++;
                        }

                        if ((r - 1 >= 0 && r - 1 < rows) &&
                                (c - 2 >= 0 && c - 2 < colls) &&
                                board[r - 1][c - 2] == 'K')
                        {
                            validAttacks++;
                        }
                        if ((r + 1 >= 0 && r + 1 < rows) &&
                                (c - 2 >= 0 && c - 2 < colls) &&
                                 board[r + 1][c - 2] == 'K')
                        {
                            validAttacks++;
                        }

                        if ((r - 1 >= 0 && r - 1 < rows) &&
                               (c + 2 >= 0 && c + 2 < colls) &&
                               board[r - 1][c + 2] == 'K')
                        {
                            validAttacks++;
                        }

                        if ((r + 1 >= 0 && r + 1 < rows) &&
                                (c + 2 >= 0 && c + 2 < colls) &&
                               board[r + 1][c + 2] == 'K')
                        {
                            validAttacks++;
                        }

                        if (validAttacks > 0 && !attk.ContainsKey(validAttacks))
                        {
                            attk.Add(validAttacks,new List<int[]>());
                            attk[validAttacks].Add(new int[]{ r, c });
                            validAttacks = 0; 
                        }
                        else if(validAttacks > 0 && attk.ContainsKey(validAttacks))
                        {
                            attk[validAttacks].Add(new int[] { r, c });
                            validAttacks = 0;
                        }
                    }
                }
            }

            if(attk.Count>0)
            {
                Redact(attk, board, counter,rows,colls);
            }
            else
            {
                Print(counter);
            }    
        }

        private static void Redact(Dictionary<int, List<int[]>> attk, char[][] board, int counter, int rows, int colls)
        {
            var key = attk.Keys.Max();
            board[attk[key][0][0]][attk[key][0][1]] = '0';
            counter++;

            PlayTheGame(board, rows, colls, counter);
        }

        private static void Print(int counter)
        {
            Console.WriteLine(counter);
        }
    }
}