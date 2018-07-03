using System;

namespace Lab_04_PascalTriangle
{
    public class PascalTriangle
    {
        public static void Main(string[] args)
        {
            ReceiveNumber();
        }

        //Receive number of rows for the Pascal triangle;
        static void ReceiveNumber()
        {
            var numberOfRows = long.Parse(Console.ReadLine());
            CreateTriangle(numberOfRows);
        }

        //Creates Pascal trinagle.
        static void CreateTriangle(long numberOfRows)
        {
            var pascalTriangle = new long[numberOfRows][];
            var number = 0L;

            for (var rows = 0; rows < numberOfRows; rows++)
            {
                pascalTriangle[rows] = new long[rows + 1];

                for (var colums = 0; colums < rows + 1; colums++)
                {
                    if ((colums == 0 || colums == rows))
                    {
                        number = 1;
                    }
                    else
                    {
                        number = pascalTriangle[rows - 1][colums - 1] + pascalTriangle[rows - 1][colums];
                    }

                    pascalTriangle[rows][colums] = number;
                }
            }

            PrintPascalTriangle(pascalTriangle);
        }

        //Prints the Pascal triangle.
        static void PrintPascalTriangle(long[][] pascalTriangle)
        {
            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}