using System;
using System.Linq;

namespace Lab_05_RoundingNumbers
{
    public class roundingNumbers
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            CreateArray(input);
        }

        static void CreateArray(string input)
        {
            var arrayOfNumbers = input.Split(' ').Select(x => decimal.Parse(x)).ToArray();

            RoundingNumbers(arrayOfNumbers);
        }

        static void RoundingNumbers(decimal[] arrayOfNymbers)
        {
            foreach (var num in arrayOfNymbers)
            {
                if (num > 0)
                {
                    if (((num * 10) % 10) == 5)
                    {
                        Console.WriteLine($"{num} = {Math.Ceiling(num)}");
                    }
                   else
                    {
                        Console.WriteLine($"{num} = {Math.Round(num)}");
                    }
                    
                }
                else if (num < 0)
                {
                    if (((num * 10) % 10)==-5)
                    {
                        Console.WriteLine($"{num} = {Math.Floor(num)}");
                    }
                    else
                    {
                        Console.WriteLine($"{num} = {Math.Round(num)}");
                    }
                }
                else if (num == 0)
                {
                    Console.WriteLine($"{num} = 0");
                }
            }
        }
    }
}
