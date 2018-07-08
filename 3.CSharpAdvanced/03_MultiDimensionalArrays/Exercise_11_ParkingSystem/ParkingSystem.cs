using System;
using System.Linq;

namespace Exercise_11_ParkingSystem
{
    public class ParkingSystem
    {
        public static void Main(string[] args)
        {
            ReceiveParkingDimentions();
        }

        //Receives the dimentions of the parkinglot from the console.
        public static void ReceiveParkingDimentions()
        {
            var parkingDimentions = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            CreateParkingLot(parkingDimentions);
        }

        //Creates  matrix represention the parkinglot.
        public static void CreateParkingLot(int[] parkingDimentions)
        {
            var parkingRows = parkingDimentions[0];
            var parkingColumns = parkingDimentions[1];
            var parkingLot = new bool[parkingRows][];

            ReceiveCars(parkingLot, parkingColumns);
        }

        //Receives incoming cars information from the console.
        static void ReceiveCars(bool[][] parkingLot, int parkingColumns)
        {
            var car = Console.ReadLine();

            while (car != "stop")
            {
                var temp = car.Split(' ').Select(y => int.Parse(y)).ToArray();
                var entryRow = temp[0];
                var targetSpaceRow = temp[1];
                var targetSpaceCol = temp[2];

                ParkTheCar(parkingLot, entryRow, targetSpaceRow, targetSpaceCol, parkingColumns);
                car = Console.ReadLine();
            }
        }

        //Parks the car on the required space. 
        static void ParkTheCar(bool[][] parkingLot, int entryRow, int targetSpaceRow, int targetSpaceCol, int parkingColumns)
        {
            var distance =1;
            var output = string.Empty;

            if (parkingLot[targetSpaceRow] == null)
            {
                parkingLot[targetSpaceRow]= new bool[parkingColumns];
            }
            if (entryRow != targetSpaceRow)
            {
                distance += Math.Abs(entryRow - targetSpaceRow);
            }

            distance += targetSpaceCol;

            if (parkingLot[targetSpaceRow][targetSpaceCol] == false)
            {          
                parkingLot[targetSpaceRow][targetSpaceCol] = true;
                output = distance.ToString();
                Print(output);
                return;
            }
            else if (parkingLot[targetSpaceRow][targetSpaceCol] == true)
            {
                var modifier = 1;
                var checker = false;

                while (checker==false)
                {
                    if (targetSpaceCol - modifier > 0 && parkingLot[targetSpaceRow][targetSpaceCol - modifier] == false)
                    {
                        parkingLot[targetSpaceRow][targetSpaceCol-modifier] = true;
                        distance -= modifier;
                        output = distance.ToString();
                        Print(output);
                        checker = true;
                    }
                  
                    else if (targetSpaceCol + modifier < parkingLot[targetSpaceRow].Length && parkingLot[targetSpaceRow][targetSpaceCol + modifier] == false)
                    {
                        parkingLot[targetSpaceRow][targetSpaceCol + modifier] = true;
                        distance += modifier;
                        output = distance.ToString();
                        Print(output);
                        checker = true;
                    }
                    else if (targetSpaceCol + modifier >= parkingLot[targetSpaceRow].Length-1 && targetSpaceCol - modifier <= 0)
                    {
                        output = $"Row {targetSpaceRow} full";
                        Print(output);
                        checker = true;
                    }

                    modifier++;
                }
            }
        }

        //Prints the output on the console.
        static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}