using System;
using System.Linq;

namespace Exercise_07_LegoBlocks
{
    public class LegoBlocks
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives information from the console.
        static void ReceiveInput()
        {
            var numberRows = int.Parse(Console.ReadLine());
            var firstArray = new string[numberRows][];
            var secondArray = new string[numberRows][];

            for (var firstNRows = 0; firstNRows < numberRows; firstNRows++)
            {
                firstArray[firstNRows] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (var secondNRows = 0; secondNRows < numberRows; secondNRows++)
            {
                secondArray[secondNRows] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            CheckCompatibility(firstArray, secondArray, numberRows);
        }

        //Checks if the arrays are compatible.
        static void CheckCompatibility(string[][] firstArray, string[][] secondArray, int numberRows)
        {
            var checker = true;
            var totalLenght = firstArray[0].Length + secondArray[0].Length;
            var totalNumberOfCells = 0;
            var finalArray = new string[numberRows][];

            for (var row = 0; row < numberRows; row++)
            {
                if (totalLenght == firstArray[row].Length + secondArray[row].Length)
                {
                    var temp = string.Join(" ", firstArray[row]) + " " + string.Join(" ", secondArray[row].Reverse());
                    CreateFinalArray(temp, row, finalArray);
                }
                else
                {
                    checker = false;
                }

                totalNumberOfCells += firstArray[row].Length + secondArray[row].Length;
            }

            if (checker == true)
            {
                PrintOutput(finalArray);
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalNumberOfCells}");
            }
        }

        //Cretes the final array. 
        static void CreateFinalArray(string temp, int row, string[][] finalArray)
        {
            finalArray[row] = temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        //Prints the final array.
        static void PrintOutput(string[][] finalArray)
        {
            foreach (var r in finalArray)
            {
                Console.WriteLine("[" + string.Join(", ", r) + "]");
            }
        }
    }
}