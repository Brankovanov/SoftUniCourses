using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_06_SquareNumbers
{
    public class squareNumbers
    {
        public static void Main(string[] args)
        {
            Print();
        }

        static void Print()
        {
            var input = Console.ReadLine();

            CreateList(input);
        }

        static void CreateList(string input)
        {
            var intList = input.Split(' ').Select(x => int.Parse(x)).ToList();
            List<double> finalList = new List<double>();

            ExtractSquare(intList, finalList);
        }

        static void ExtractSquare(List<int> intList, List<double> finalList)
        {
            foreach (var num in intList)
            {
                var answer = Math.Sqrt(num);

                if (answer % 1 == 0)
                {
                    finalList.Add((num));
                }
            }

            finalList.Sort();
            finalList.Reverse();

            foreach (var num in finalList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
