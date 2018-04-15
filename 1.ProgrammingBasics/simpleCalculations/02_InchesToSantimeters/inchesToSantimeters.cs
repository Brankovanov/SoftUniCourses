using System;

namespace _02_InchesToSantimeters
{
    public class inchesToSantimeters
    {
        public static void Main(string[] args)
        {
            var inch = double.Parse(Console.ReadLine());

            var sm = inch * 2.54;

            Console.WriteLine(sm);
        }
    }
}
