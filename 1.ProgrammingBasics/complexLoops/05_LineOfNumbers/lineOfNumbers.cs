using System;

namespace _05_LineOfNumbers
{
    public class lineOfNumbers
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
           
            for (var n = 1; n <= input; n=n*2+1)
            {
                Console.WriteLine(n);
            }
        }
    }
}
