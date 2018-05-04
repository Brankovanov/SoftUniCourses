using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_08_CondenceArrayToNumber
{
    public class condemceArrayToNumber
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var numberArray = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            Condence(numberArray);
        }

        static void Condence(int[] numberArray)
        {
            var sum = 0;

            for (var round = 0; round <= numberArray.Length - 2; round++)
            {
                for (var index = 0; index <= numberArray.Length - 2; index++)
                {
                    sum = numberArray[index] + numberArray[index + 1];

                    numberArray[index] = sum;
                }
            }

            Output(numberArray);
        }

        static void Output(int[] numberArray)
        {
            Console.WriteLine(numberArray[0].ToString());
        }
    }
}
