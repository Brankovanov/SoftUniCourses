using System;

namespace _01_NumbersWithStepThree
{
    public class numbersWIthStepThree
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for(var n=1; n<=input;n=n+3)
            {
                Console.WriteLine(n);
            }
        }
    }
}
