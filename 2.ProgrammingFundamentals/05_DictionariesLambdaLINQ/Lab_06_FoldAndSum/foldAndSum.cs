using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_06_FoldAndSum
{
    public class foldAndSum
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var numInput = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList();

            FoldList(numInput);
        }

        static void FoldList(List<int> numInput)
        {
            List<int> foldedList = new List<int>();
            var count = numInput.Count / 4;

            foldedList.AddRange(numInput);
            foldedList.RemoveRange(count, count*3);
            foldedList.Reverse();
            numInput.RemoveRange(0, count);
            numInput.Reverse();
            foldedList.AddRange(numInput);
            foldedList.RemoveRange(count * 2, count*2);
            numInput.RemoveRange(0, count);
            numInput.Reverse();

            Calculate(foldedList, numInput, count);
        }

        static void Calculate(List<int> foldedList, List<int> numInput, int count)
        {
            List<int> finalList = new List<int>();
            var answer = 0;

            for (var index = 0; index <= (count*2)-1; index++)
            {
                answer = foldedList[index]+numInput[index];
                finalList.Add(answer);
                answer = 0;
            }

            Print(finalList);
        }

        static void Print(List<int> finalList)
        {
            foreach (var member in finalList)
            {
                Console.Write(member + " ");
            }
        }
    }
}
