using System;

namespace Exercise_04_NumbersInRevrse
{
    public class numbersInReverse
    {
        public static void Main(string[] args)
        {
            var number = Console.ReadLine();

            Reverse(number);
        }

        static void Reverse(string number)
        {
            var output = string.Empty;

            foreach (var ch in number)
            {
                output = ch.ToString() + output;
            }

            Console.WriteLine(output);
        }
    }
}
