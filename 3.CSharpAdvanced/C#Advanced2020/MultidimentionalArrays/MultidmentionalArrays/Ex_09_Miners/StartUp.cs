using System;

namespace Ex_09_Miners
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

            CreateField(dimentions);
        }

        private static void CreateField(int dimentions)
        {
            var field = new string[dimentions][];

            var commands = ReceiveCommands();

            BuildField(field, dimentions);

            CalculateFeatures(field, commands, dimentions);
        }

        private static void BuildField(string[][] field, int dimentions)
        {
            for (var r = 0; r < dimentions; r++)
            {
                var temp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                field[r] = temp;
            }
        }

        private static void CalculateFeatures(string[][] field, string[] commands, int dimentions)
        {
            var coalTotal = 0;
            var workerRow = 0;
            var workerCol = 0;
            var endRow = 0;
            var endCol = 0;

            for (var r = 0; r < dimentions; r++)
            {
                for (var c = 0; c < dimentions; c++)
                {
                    if (field[r][c] == "c")
                    {
                        coalTotal++;
                    }
                    else if (field[r][c] == "s")
                    {
                        workerRow = r;
                        workerCol = c;
                    }
                    else if (field[r][c] == "e")
                    {
                        endRow = r;
                        endCol = c;
                    }
                }
            }

            ExecuteCommands(field, commands, dimentions, coalTotal, workerRow, workerCol, endRow, endCol);
        }

        private static void ExecuteCommands(string[][] field, string[] commands,
            int dimentions, int coalTotal, int workerRow, int workerCol, int endRow, int endCol)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case "up":
                        if (workerRow > 0)
                        {
                            workerRow--;
                        }
                        break;

                    case "down":
                        if (workerRow < dimentions-1)
                        {
                            workerRow++;
                        }
                        break;

                    case "right":
                        if (workerCol < dimentions-1)
                        {
                            workerCol++;
                        }
                        break;

                    case "left":
                        if (workerCol > 0)
                        {
                            workerCol--;
                        }
                        break;
                }

                if (field[workerRow][workerCol] == "c")
                {
                    coalTotal--;
                    field[workerRow][workerCol] = "*";

                    if (coalTotal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({workerRow}, {workerCol})");
                        Environment.Exit(1);
                    }
                }
                else if(field[workerRow][workerCol]=="e")
                {
                    Console.WriteLine($"Game over! ({workerRow}, {workerCol})");
                    Environment.Exit(1);
                }
            }

            Console.WriteLine($"{coalTotal} coals left. ({workerRow}, {workerCol})");
        }

        private static string[] ReceiveCommands()
        {
            var temp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return temp;  
        }
    }
}
