using System;
using System.Linq;

namespace Lab_06_ReverseArrayOfStrings
{
    public class reverseArrayOfString
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            GenerateArray(input);
        }

        static void GenerateArray(string input)
        {
            var stringArray = input.Split(' ');

            ReverseString(stringArray);
        }

        static void ReverseString(string[] stringArray)
        {
            foreach (var str in stringArray.Reverse())
            {
                Console.Write(str + " ");
            }
        }
    }
}
