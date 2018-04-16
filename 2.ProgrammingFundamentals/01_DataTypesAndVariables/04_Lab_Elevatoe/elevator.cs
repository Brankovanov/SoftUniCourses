using System;

namespace _04_Lab_Elevatoe
{
    public class elevator
    {
        public static void Main(string[] args)
        {
            var numberOfPeople = double.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());

            double courses = numberOfPeople / capacity;

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
