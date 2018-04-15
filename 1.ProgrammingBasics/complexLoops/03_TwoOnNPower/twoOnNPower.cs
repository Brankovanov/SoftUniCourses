using System;

namespace _03_TwoOnNPower
{
    public class twoOnNPower
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var two = 1;

            for (var n = 0; n <=input; n++)
            {
                Console.WriteLine(two);
                two = two * 2;               
            }
        }
    }
}
