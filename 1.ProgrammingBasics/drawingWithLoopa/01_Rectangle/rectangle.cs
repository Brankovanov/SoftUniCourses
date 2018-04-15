using System;

namespace _01_Rectangle
{
    public class rectangle
    {
        public static void Main(string[] args)
        {
            for (var m=1; m<=10; m++)
            {
                for (var n=1;n<=10; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
