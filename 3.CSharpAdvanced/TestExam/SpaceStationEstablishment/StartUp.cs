
using System;

namespace SpaceStationEstablishment
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var size = int.Parse(Console.ReadLine());

            var galaxy = new char[size, size];
            var rowCoordinate = 0;
            var collCoordinate = 0;
            var energy = 0;
            var bhOneRow = 0;
            var bhOneColl = 0;
            var bhTwoRow = 0;
            var bhTwoColl = 0;

            for (var row = 0; row < size; row++)
            {
                var r = Console.ReadLine().ToCharArray();

                for (var coll = 0; coll < size; coll++)
                {
                    galaxy[row, coll] = r[coll];

                    if (r[coll] == 'S' )
                    {
                        rowCoordinate = row;
                        collCoordinate = coll;
                    }
                    else if (r[coll] == 'O')
                    {
                        if (bhOneColl == 0 && bhOneRow == 0)
                        {
                            bhOneRow = row;
                            bhOneColl = coll;
                        }
                        else
                        {
                            bhTwoColl = coll;
                            bhTwoRow = row;
                        }
                    }

                }
            }
            var commands = Console.ReadLine();
            while ((rowCoordinate >= 0 && rowCoordinate < size) && (collCoordinate >= 0 && collCoordinate < size)|| energy<50)
            {
               

                ExecuteCommands(commands, rowCoordinate, collCoordinate, galaxy, energy, bhOneColl, bhOneRow, bhTwoRow, bhTwoColl);
                commands = Console.ReadLine();
            }

            PrintResults(galaxy, energy, size);
        }

        public static void ExecuteCommands(string commands, int rowCoordinate, int collCoordinate, char[,] galaxy, int energy,
            int bhOneColl, int bhOneRow, int bhTwoRow, int bhTwoColl)
        {
            switch (commands)
            {
                case "up":
                    galaxy[rowCoordinate, collCoordinate] = '-';
                    rowCoordinate++;
                    
                    ResolveMovement(rowCoordinate, collCoordinate, galaxy, energy,
                        bhOneColl, bhOneRow, bhTwoRow, bhTwoColl);
                    break;
                case "down":
                    galaxy[rowCoordinate, collCoordinate] = '-';
                    rowCoordinate--;
                    
                    ResolveMovement(rowCoordinate, collCoordinate, galaxy, energy,
                        bhOneColl, bhOneRow, bhTwoRow, bhTwoColl);
                    break;
                case "left":
                    galaxy[rowCoordinate, collCoordinate] = '-';
                    collCoordinate--;
                    
                    ResolveMovement(rowCoordinate, collCoordinate, galaxy, energy,
                        bhOneColl, bhOneRow, bhTwoRow, bhTwoColl);
                    break;
                case "right":
                    galaxy[rowCoordinate, collCoordinate] = '-';
                    collCoordinate++;
                    
                    ResolveMovement(rowCoordinate, collCoordinate, galaxy, energy,
                        bhOneColl, bhOneRow, bhTwoRow, bhTwoColl);
                    break;
            }
        }

        public static void ResolveMovement(int rowCoordinate, int collCoordinate, char[,] galaxy, int energy,
            int bhOneColl, int bhOneRow, int bhTwoRow, int bhTwoColl)
        {
            if (char.IsDigit(galaxy[rowCoordinate, collCoordinate]))
            {
                energy += int.Parse(galaxy[rowCoordinate, collCoordinate].ToString());
                galaxy[rowCoordinate, collCoordinate] = 'S';
            }
            else if (galaxy[rowCoordinate, collCoordinate] == 'O')
            {
                if (rowCoordinate == bhOneRow && collCoordinate == bhOneColl)
                {
                    rowCoordinate = bhTwoRow;
                    collCoordinate = bhTwoColl;

                    galaxy[bhOneRow, bhOneColl] = '-';
                    galaxy[bhTwoRow, bhTwoColl] = 'S';
                    
                }
                else
                {
                    rowCoordinate = bhOneRow;
                    collCoordinate = bhOneColl;

                    galaxy[bhOneRow, bhOneColl] = 'S';
                    galaxy[bhTwoRow, bhTwoColl] = '-';
                    
                }
            }
            else if(galaxy[rowCoordinate, collCoordinate] == '-')
            {
                galaxy[rowCoordinate, collCoordinate] = 'S';
            }
        }

     
        public static void PrintResults(char[,]galaxy,int energy,int size)
        {
            if(energy>=50)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }

            Console.WriteLine($"Star power collected: {energy}");

            for (var row = 0; row < size; row++)
            {
                
                for (var coll = 0; coll < size; coll++)
                {
                    Console.Write(galaxy[row, coll]);
                }
                Console.WriteLine();
            }
        }
    }
}
