using System;

namespace _15_Tiles
{
    public class tiles
    {
        public static void Main(string[] args)
        {
            ReceivesInput();
        }

        //Receives input from the console.
        static void ReceivesInput()
        {
            var yardSide = int.Parse(Console.ReadLine());
            var tileWidht = double.Parse(Console.ReadLine());
            var tileLenght = double.Parse(Console.ReadLine());
            var benchWidht = int.Parse(Console.ReadLine());
            var benchLenght = int.Parse(Console.ReadLine());

            Calculate(yardSide, tileWidht, tileLenght, benchWidht, benchLenght);
        }

        //Calculates the neccessary tiles and time.
        static void Calculate(int yardSide, double tileWidht, double tileLenght, int benchWidht, int benchLenght)
        {
            var yardSize = Math.Pow(yardSide, 2);
            var tileSize = tileLenght * tileWidht;
            var benchSize = benchLenght * benchWidht;
            yardSize = yardSize - benchSize;
            var numberOfTiles = yardSize / tileSize;
            var timeToPutTheTiles = numberOfTiles * 0.2;

            PrintResult(numberOfTiles, timeToPutTheTiles);
        }

        //Prints the results.
        static void PrintResult(double numberOfTiles, double timeToPutTiles)
        {
            Console.WriteLine(String.Format("{0:0.00}", numberOfTiles));
            Console.WriteLine(String.Format("{0:0.00}", timeToPutTiles));
        }
    }
}