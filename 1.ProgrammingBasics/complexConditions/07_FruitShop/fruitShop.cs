using System;

namespace _07_FruitShop
{
    public class fruitShop
    {
        public static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (day.Equals("Sunday") || day.Equals("Saturday"))
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine(Math.Round((quantity * 2.7), 2));
                        break;
                    case "apple":
                        Console.WriteLine(Math.Round((quantity * 1.25), 2));
                        break;
                    case "orange":
                        Console.WriteLine(Math.Round((quantity * 0.9), 2));
                        break;
                    case "grapefruit":
                        Console.WriteLine(Math.Round((quantity * 1.6), 2));
                        break;
                    case "kiwi":
                        Console.WriteLine(Math.Round((quantity * 3), 2));
                        break;
                    case "pineapple":
                        Console.WriteLine(Math.Round((quantity * 5.6), 2));
                        break;
                    case "grapes":
                        Console.WriteLine(Math.Round((quantity * 4.2), 2));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday") || day.Equals("Friday"))
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine(Math.Round((quantity * 2.5), 2));
                        break;
                    case "apple":
                        Console.WriteLine(Math.Round((quantity * 1.20), 2));
                        break;
                    case "orange":
                        Console.WriteLine(Math.Round((quantity * 0.85), 2));
                        break;
                    case "grapefruit":
                        Console.WriteLine(Math.Round((quantity * 1.45), 2));
                        break;
                    case "kiwi":
                        Console.WriteLine(Math.Round((quantity * 2.7), 2));
                        break;
                    case "pineapple":
                        Console.WriteLine(Math.Round((quantity * 5.5), 2));
                        break;
                    case "grapes":
                        Console.WriteLine(Math.Round((quantity * 3.85), 2));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {

                Console.WriteLine("error");
            }
        }
    }
}

