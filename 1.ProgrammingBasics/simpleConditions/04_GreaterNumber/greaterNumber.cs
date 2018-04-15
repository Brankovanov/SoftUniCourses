using System;

namespace _04_GreaterNumber
{
    public class greaterNumber
    {
        public static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());

            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else
            {
                Console.WriteLine(numTwo);
            }
        }
    }
}
