using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01_TakeTwo
{
    public class TakeTwo
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives a collection of numbers from the console.
        public static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToList();
            SortNumbers(input);
        }

        //Finds the numbers in the collection 10<=n<=20.
        public static void SortNumbers(List<int> input)
        {
            foreach (var num in input.Where(n => n >= 10 && n <= 20).Take(2))
            {
                PrintFirstTwo(num);
            }
        }

        //Prints the first to members of the collection.
        public static void PrintFirstTwo(int num)
        {
            Console.Write(num + " ");
        }
    }
}