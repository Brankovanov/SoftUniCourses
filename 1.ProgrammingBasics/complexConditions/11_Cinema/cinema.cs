using System;

namespace _11_Cinema
{
    public class cinema
    {
        public static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var seats = r * c;

            switch (type)
            {
                case "Premiere":
                    Console.WriteLine("{0:f2}", seats * 12);
                    break;
                case "Normal":
                    Console.WriteLine("{0:f2}", seats * 7.5);
                    break;
                case "Discount":
                    Console.WriteLine("{0:f2}", seats * 5);
                    break;
            }
        }
    }
}
