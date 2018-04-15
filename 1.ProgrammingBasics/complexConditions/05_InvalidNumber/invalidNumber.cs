using System;

namespace _05_InvalidNumber
{
    public class invalidNumber
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num >= 100 && num <= 200 || num == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
