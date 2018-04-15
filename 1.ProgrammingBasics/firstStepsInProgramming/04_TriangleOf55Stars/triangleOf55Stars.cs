using System;

namespace _04_TriangleOf55Stars
{
    public class triangleOf55Stars
    {
        public static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                for (var x = 1; x <= i; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
