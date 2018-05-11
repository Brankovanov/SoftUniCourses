using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01_RemoveNegativeAndReverse
{
    public class removeNegativeAndReverse
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
            List<int> numList = input.Split(' ').Select(x => int.Parse(x)).ToList();

            ProccessList(numList);
        }

        static void ProccessList(List<int> numList)
        {
            var counter = false;

            numList.Reverse();

            foreach (var num in numList)
            {
                if (num > 0)
                {
                    Console.Write(num + " ");

                    counter = true;
                }
            }

            if (counter == false)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
