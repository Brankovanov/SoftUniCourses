using System;
using System.Linq;

namespace Ex_08_Bombs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveDimentions();
        }

        private static void ReceiveDimentions()
        {
            var dimentions = int.Parse(Console.ReadLine());

            CreateMatrix(dimentions);
        }

        private static void CreateMatrix(int dimentions)
        {
            var mineField = new int[dimentions][];

            for (var row = 0; row < dimentions; row++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

                mineField[row] = input;
            }

            PlantMines(mineField, dimentions);
        }

        private static void PlantMines(int[][] mineField, int dimentions)
        {
            var mines = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray()).ToArray();

            ExplodeMines(mines, mineField, dimentions);
        }

        private static void ExplodeMines(int[][] mines, int[][] mineField, int dimentions)
        {
            foreach (var mine in mines)
            {
                var mineRow = mine[0];
                var mineColumn = mine[1];
                var explodingMine = mineField[mineRow][mineColumn];

                if (mineField[mineRow][mineColumn] > 0)
                {
                    for (var r = mineRow - 1; r <= mineRow + 1; r++)
                    {
                        for (var c = mineColumn - 1; c <= mineColumn + 1; c++)
                        {
                            if ((r >= 0 && r < dimentions) && (c >= 0 && c < dimentions))
                            {
                                if(mineField[r][c]>0)
                                {
                                    mineField[r][c] -= explodingMine;
                                }                       
                            }
                        }
                    }
                }
            }

            CalculateAftermath(mineField, dimentions);
        }

        private static void CalculateAftermath(int[][] mineField, int dimentions)
        {
            var counter = 0;
            var sum = 0;

            for (var r = 0; r < dimentions; r++)
            {
                for (var c = 0; c < dimentions; c++)
                {
                    if (mineField[r][c] > 0)
                    {
                        counter++;
                        sum += mineField[r][c];
                    }
                }
            }

            PrintResult(counter, sum, dimentions, mineField);
        }

        private static void PrintResult(int counter, int sum, int dimentions, int[][] mineField)
        {
            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sum}");

            for(var r=0;r<dimentions;r++)
            {
                Console.WriteLine(string.Join(' ', mineField[r]));
            }
        }
    }
}