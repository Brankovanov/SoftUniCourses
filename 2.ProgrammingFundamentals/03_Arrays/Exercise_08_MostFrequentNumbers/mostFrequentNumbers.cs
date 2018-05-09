using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_08_MostFrequentNumbers
{
    public class mostFrequentNumbers
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            SplitInput(input);
        }

        static void SplitInput(string input)
        {
            var numberArray = input.Split(' ').Select(x => int.Parse(x)).ToList();

            CompareNumbers(numberArray);
        }

        static void CompareNumbers(List<int> numberArray)
        {
            var counter = 0;
            var finalCount = 0;
            var answer = 0;

            for (var index = 0; index <= numberArray.Count - 1; index++)
            {
                for (var innerIndex = 0; innerIndex <= numberArray.Count - 1; innerIndex++)
                {
                    if (numberArray[index] == numberArray[innerIndex])
                    {
                        counter++;
                    }
                }

                if (counter > finalCount)
                {
                    finalCount = counter;
                    counter = 0;
                    answer = int.Parse(numberArray[index].ToString());
                }
                else if (counter <= finalCount)
                {
                    counter = 0;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
