using System;

namespace _12_CurrencyConverter
{
    public class currencyConverter
    {
        public static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            switch (input)
            {
                case "BGN":
                    switch (output)
                    {
                        case "BGN":
                            Console.WriteLine(Math.Round(value, 2));
                            break;
                        case "USD":
                            Console.WriteLine(Math.Round(value / 1.79549, 2));
                            break;
                        case "EUR":
                            Console.WriteLine(Math.Round(value / 1.95583, 2));
                            break;
                        case "GBP":
                            Console.WriteLine(Math.Round(value / 2.53405, 2));
                            break;
                    }
                    break;

                case "USD":
                    var bg = value * 1.79549;

                    switch (output)
                    {
                        case "BGN":
                            Console.WriteLine(Math.Round(bg, 2));
                            break;
                        case "USD":
                            Console.WriteLine(Math.Round(bg / 1.79549, 2));
                            break;
                        case "EUR":
                            Console.WriteLine(Math.Round(bg / 1.95583, 2));
                            break;
                        case "GBP":
                            Console.WriteLine(Math.Round(bg / 2.53405, 2));
                            break;
                    }
                    break;

                    break;

                case "EUR":
                    bg = value * 1.95583;

                    switch (output)
                    {
                        case "BGN":
                            Console.WriteLine(Math.Round(bg, 2));
                            break;
                        case "USD":
                            Console.WriteLine(Math.Round(bg / 1.79549, 2));
                            break;
                        case "EUR":
                            Console.WriteLine(Math.Round(bg / 1.95583, 2));
                            break;
                        case "GBP":
                            Console.WriteLine(Math.Round(bg / 2.53405, 2));
                            break;
                    }
                    break;

                case "GBP":
                    bg = value * 2.53405;

                    switch (output)
                    {
                        case "BGN":
                            Console.WriteLine(Math.Round(bg, 2));
                            break;
                        case "USD":
                            Console.WriteLine(Math.Round(bg / 1.79549, 2));
                            break;
                        case "EUR":
                            Console.WriteLine(Math.Round(bg / 1.95583, 2));
                            break;
                        case "GBP":
                            Console.WriteLine(Math.Round(bg / 2.53405, 2));
                            break;
                    }
                    break;
            }
        }
    }
}
