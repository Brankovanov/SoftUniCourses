using System;

namespace _16_MagicNumbers
{
    public class magicNumbers
    {
        public static void Main(string[] args)
        {
            var magicNumber = int.Parse(Console.ReadLine());
            var value = 1;

            for (var numbers = 100000; numbers <= 999999; numbers++)
            {
                foreach (var ch in numbers.ToString())
                {
                    value = value * int.Parse(ch.ToString());
                }

                if (value == magicNumber)
                {
                    Console.Write(numbers + " ");
                }
                value = 1;
            }
        }
    }
}
