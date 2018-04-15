using System;

namespace _15_journey
{
    public class journey
    {
        public static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = (Console.ReadLine());

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine("Camp - " + Math.Round((budget * 0.3), 2));
                        break;
                    case "winter":
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine("Hotel - " + Math.Round((budget * 0.7), 2));
                        break;
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                switch (season)
                {
                    case "summer":
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine("Camp - " + Math.Round((budget * 0.4), 2));
                        break;
                    case "winter":
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine("Hotel - " + Math.Round((budget * 0.8), 2));
                        break;
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - " + Math.Round((budget * 0.9), 2));
            }

        }
    }
}
