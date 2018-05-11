using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_03_SumAdjancedEqualNumber
{
    public class sumAdjancedEqualNumbers
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            CreateList(input);
        }

        static void CreateList(string input)
        {
            var newList = input.Split(' ').Select(x => decimal.Parse(x)).ToList();

            SumNumbers(newList);
        }

        static void SumNumbers(List<decimal> newList)
        {
            for (var index = 1; index <= newList.Count - 1; index = index)
            {
                if (newList[index - 1] == newList[index])
                {
                    newList[index - 1] += newList[index - 1];
                    newList.RemoveAt(index);
                    index = 1;
                }
                else
                {
                    index++;
                }
            }

            Print(newList);
        }

        static void Print(List<decimal> newList)
        {
            foreach (var num in newList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
