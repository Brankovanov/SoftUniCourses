using System;

namespace _02_ExcellentOrNot
{
    public class excellentOrNot
    {
        public static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not Excellent.");
            }
        }
    }
}
