using System;

namespace _17_Tickets
{
    public class tickets
    {
        public static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            if (people >= 1 && people <= 4)
            {
                var transportation = budget * 0.75;

                switch (category)
                {
                    case "VIP":

                        var total = people * 499.99;
                        var difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;

                    case "Normal":

                        total = people * 249.99;
                        difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;
                }
            }
            else if (people >= 5 && people <= 9)
            {
                var transportation = budget * 0.6;

                switch (category)
                {
                    case "VIP":

                        var total = people * 499.99;
                        var difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;

                    case "Normal":

                        total = people * 249.99;
                        difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;
                }
            }
            else if (people >= 10 && people <= 24)
            {
                var transportation = budget * 0.5;

                switch (category)
                {
                    case "VIP":

                        var total = people * 499.99;
                        var difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;

                    case "Normal":

                        total = people * 249.99;
                        difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;
                }
            }
            else if (people >= 25 && people <= 49)
            {
                var transportation = budget * 0.4;

                switch (category)
                {
                    case "VIP":

                        var total = people * 499.99;
                        var difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;

                    case "Normal":

                        total = people * 249.99;
                        difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;
                }
            }
            else if (people >= 50)
            {
                var transportation = budget * 0.25;

                switch (category)
                {
                    case "VIP":

                        var total = people * 499.99;
                        var difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;

                    case "Normal":

                        total = people * 249.99;
                        difference = (budget - transportation) - total;

                        if (difference > 0)
                        {
                            Console.WriteLine("Yes! You have " + string.Format("{0:0.00}", difference) + " leva left.");
                        }
                        else
                        {
                            difference = Math.Abs(difference);
                            Console.WriteLine("Not enough money! You need " + string.Format("{0:0.00}", difference) + " leva.");
                        }

                        break;
                }               
            }
        }
    }
}
