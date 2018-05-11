using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05_SortNumbers
{
    public class sortNumbers
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
            var listOfNumbers = input.Split(' ').Select(x => decimal.Parse(x)).ToList();

            Sort(listOfNumbers);
        }

        static void Sort(List<decimal> listOfNumbers)
        {
            listOfNumbers.Sort();

            Print(listOfNumbers);
        }

        static void Print(List<decimal> listOfNumbers)
        {
            var answer = string.Empty;

            foreach (var number in listOfNumbers)
            {
                answer += number.ToString() + " <= ";
            }

            Console.WriteLine(answer.TrimEnd(' ', '<', '='));
        }
    }
}
