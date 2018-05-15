using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_ReverseNumSum
{
    public class reverseNumSum
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            CrearteList(input);
        }

        static void CrearteList(string input)
        {
            List<string>numbersList = new List<string>();
            numbersList = input.Split(' ').ToList();

            ReverseAndSumNumbers(numbersList);
        }

        static void ReverseAndSumNumbers(List<string>numberList)
        {
            var sum = 0;
            var reversed = string.Empty;
            
            foreach(var num in numberList)
            {
                reversed = new string(num.Reverse().ToArray());
                sum += int.Parse(reversed);
            }
            
            Print(sum);
        }

        static void Print(int sum)
        {
            Console.Write(sum);
        }
    }
}
