using System;

namespace _14_Exercise_IntToHexAndBinary
{
    public class intToHexAndBinary
    {
        public static void Main(string[] args)
        {
            var intInput = int.Parse(Console.ReadLine());

            var hexValue = intInput.ToString("X");

            var binary = Convert.ToString(intInput, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binary);
        }
    }
}
