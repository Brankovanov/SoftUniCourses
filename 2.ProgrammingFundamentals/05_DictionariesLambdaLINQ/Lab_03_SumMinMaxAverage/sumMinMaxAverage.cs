using System;
using System.Collections.Generic;

namespace Lab_03_SumMinMaxAverage
{
    public class sumMinMaxAverage
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            var count = int.Parse(Console.ReadLine());
            List<int> listOfNumbers = new List<int>();

            for (var index = 1; index <= count; index++)
            {
                listOfNumbers.Add(int.Parse(Console.ReadLine()));
            }

            Calculate(listOfNumbers, count);
        }

        static void Calculate(List<int> listOfNumbers, int count)
        {
            var sum = 0.0;
            double min = listOfNumbers[0];
            double max = listOfNumbers[0];
            var average = 0.0;

            foreach (var num in listOfNumbers)
            {
                sum += num;

                if (min > num)
                {
                    min = num;
                }

                if (max < num)
                {
                    max = num;
                }
            }

            average = sum / count;
            Print(sum, min, max, average);
        }

        static void Print(double sum, double min, double max, double average)
        {
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Average = " + average);
        }
    }
}
