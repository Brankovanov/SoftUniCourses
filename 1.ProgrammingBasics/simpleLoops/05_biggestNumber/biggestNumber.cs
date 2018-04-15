using System;

namespace _05_biggestNumber
{
    public class biggestNumber
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var inputNum = 0;       
            var num = int.MinValue;

            for (var n = 1; n <= input; n++)
            {
                inputNum = int.Parse(Console.ReadLine());
                
                if (num < inputNum)
                {
                    num = inputNum;
                }

                inputNum = 0;
            }

            Console.WriteLine(num);
        }
    }
}
