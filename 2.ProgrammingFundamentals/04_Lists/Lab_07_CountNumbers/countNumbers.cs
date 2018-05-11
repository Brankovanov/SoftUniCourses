using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_07_CountNumbers
{
    public class countNumbers
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

            SortList(numList);
        }

        static void SortList(List<int> numList)
        {
            var counter = 0;
            numList.Sort();

            for (var index = 0; index <= numList.Count - 1; index++)
            {
                foreach (var num in numList)
                {
                    if (numList[index] == num)
                    {
                        counter++;
                    }
                }

                var number = numList[index];
                numList.RemoveRange(index, counter - 1);
                Console.WriteLine(number + " -> " + counter);
                counter = 0;
            }
        }
    }
}
