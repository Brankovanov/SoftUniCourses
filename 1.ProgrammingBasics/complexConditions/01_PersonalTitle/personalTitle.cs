using System;

namespace _01_PersonalTitle
{
    public class personalTitle
    {
        public static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());

            var gender = Console.ReadLine();

            if (age >= 16)
            {
                if (gender.Equals("m"))
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (gender.Equals("m"))
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
