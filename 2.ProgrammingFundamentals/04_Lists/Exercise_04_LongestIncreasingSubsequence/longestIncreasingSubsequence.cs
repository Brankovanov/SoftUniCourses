using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_04_LongestIncreasingSubsequence
{
    public class longestIncreasingSubsequence
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
            var mainList = input.Split(' ').Select(x => int.Parse(x)).ToList();

            SortArray(mainList);
        }

        static void SortArray(List<int> mainList)
        {
            var finalList = new List<int>();
            var tempList = new List<int>();
            var secondTempList = new List<int>();

            if (mainList.Count == 1)
            {
                Console.Write(mainList[0]);
            }

            for (var index = 0; index <= mainList.Count - 2; index++)
            {
                tempList.Add(mainList[index]);

                for (var innerIndex = index + 1; innerIndex <= mainList.Count - 1; innerIndex++)
                {
                    if (tempList[tempList.Count - 1] < mainList[innerIndex])
                    {
                        tempList.Add(mainList[innerIndex]);
                    }
                    else if (tempList[tempList.Count - 1] > mainList[innerIndex])
                    {
                        var tempVar = mainList[innerIndex];

                        CheckingInTempList(tempList, secondTempList, tempVar);

                        tempVar = 0;
                    }
                }

                if (tempList.Count > secondTempList.Count)
                {
                    if (tempList.Count > finalList.Count)
                    {
                        finalList.RemoveRange(0, finalList.Count);
                        finalList.AddRange(tempList);
                        tempList.RemoveRange(0, tempList.Count);
                    }
                    else
                    {
                        tempList.RemoveRange(0, tempList.Count);
                    }

                    secondTempList.RemoveRange(0, secondTempList.Count);
                }
                else if (tempList.Count <= secondTempList.Count)
                {
                    if (secondTempList.Count > finalList.Count)
                    {
                        finalList.RemoveRange(0, finalList.Count);
                        finalList.AddRange(secondTempList);
                        secondTempList.RemoveRange(0, secondTempList.Count);
                    }
                    else
                    {
                        secondTempList.RemoveRange(0, secondTempList.Count);
                    }

                    tempList.RemoveRange(0, tempList.Count);
                }

            }

            Print(finalList);
        }

        static void CheckingInTempList(List<int> tempList, List<int> secondTempList, int tempVar)
        {
            for (var tempIndex = tempList.Count - 1; tempIndex >= 0; tempIndex--)
            {
                if (tempList[tempIndex] < tempVar)
                {
                    secondTempList.RemoveRange(0, secondTempList.Count);
                    secondTempList.AddRange(tempList);
                    secondTempList.RemoveAll(x => x > tempList[tempIndex + 1]);

                    tempList.RemoveAll(t => t > tempVar);
                    tempList.Add(tempVar);
                    break;
                }
                else if (tempList[tempIndex] == tempVar)
                {
                    break;
                }
            }
        }

        static void Print(List<int> finalList)
        {

            foreach (var num in finalList)
            {
                Console.Write(num + " ");
            }
        }
    }
}

