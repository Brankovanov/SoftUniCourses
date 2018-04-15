using System;

namespace _11_USDToBGN
{
    public class usToBgn
    {
        public static void Main(string[] args)
        {
            var us = double.Parse(Console.ReadLine());

            var bg = us * 1.79549;

            Console.WriteLine(Math.Round(bg, 2));
        }
    }
}
