using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04_LargestTreeNumbers
{
    public class largestThreeNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            var input = Console.ReadLine();
            CreateList(input);
        }

        static void CreateList(string input)
        {
            List<int> listOfNumber = new List<int>();

            listOfNumber = input.Split(' ').Select(x => int.Parse(x)).ToList();
            FindBiggestNums(listOfNumber);
        }

        static void FindBiggestNums(List<int> listOfNumber)
        {
            listOfNumber.Sort();
            listOfNumber.Reverse();

            if (listOfNumber.Count - 1 < 3)
            {
                foreach (var num in listOfNumber)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                for (var index = 0; index <= 2; index++)
                {                    
                       Console.Write(listOfNumber[index]+ " ");                    
                }
            }
        }
    }
}
