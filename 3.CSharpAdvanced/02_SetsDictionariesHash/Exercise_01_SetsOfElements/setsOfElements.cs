using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_01_SetsOfElements
{
    public class setsOfElements
    {
        public static void Main(string[] args)
        {
            ReceiveElements();
        }

        //Receives the number of elements in every set and the elements of the sets from the console.
        static void ReceiveElements()
        {
            var setOne = new HashSet<int>();
            var setTwo = new HashSet<int>();
            var setCounts = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
            var setOneCount = setCounts[0];
            var setTwoCount = setCounts[1];

            for (var index = 1; index <= setOneCount; index++)
            {
                setOne.Add(int.Parse(Console.ReadLine()));
            }

            for (var secondIndex = 1; secondIndex <= setTwoCount; secondIndex++)
            {
                setTwo.Add(int.Parse(Console.ReadLine()));
            }

            FindCommonElements(setOne, setTwo);
        }

        //Finds the common elements of the two sets and prints them.
        static void FindCommonElements(HashSet<int> setOne, HashSet<int> setTwo)
        {
            if (setOne.Count < setTwo.Count)
            {
                foreach (var element in setOne)
                {
                    if (setTwo.Contains(element))
                    {
                        Console.Write(element + " ");
                    }
                }
            }
            else
            {
                foreach (var element in setTwo)
                {
                    if (setOne.Contains(element))
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }
    }
}