using System;

namespace _15_EqualNumbers
{
    public class equalNumbers
    {
        public static void Main(string[] args)
        {
            var numOne = double.Parse(Console.ReadLine());
            var numTwo = double.Parse(Console.ReadLine());
            var numThree = double.Parse(Console.ReadLine());

            if (numOne == numTwo && numTwo == numThree)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
