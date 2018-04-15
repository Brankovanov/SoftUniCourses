using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TradeCommission
{
    public class tradeCommision
    {
        public static void Main(string[] args)
        {
            var city = Console.ReadLine();
            var sels = double.Parse(Console.ReadLine());

            if (sels >= 0 && sels <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:f2}", sels * (5.0 / 100));
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:f2}", sels * (5.5 / 100));
                        break;
                    case "Varna":
                        Console.WriteLine("{0:f2}", sels * (4.5 / 100));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sels >= 500 && sels <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:f2}", sels * (7.0 / 100));
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:f2}", sels * (8.0 / 100));
                        break;
                    case "Varna":
                        Console.WriteLine("{0:f2}", sels * (7.5 / 100));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sels >= 1000 && sels <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:f2}", sels * (8.0 / 100));
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:f2}", sels * (12.0 / 100));
                        break;
                    case "Varna":
                        Console.WriteLine("{0:f2}", sels * (10.0 / 100));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sels > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:f2}", sels * (12.0 / 100));
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:f2}", sels * (14.5 / 100));
                        break;
                    case "Varna":
                        Console.WriteLine("{0:f2}", sels * (13.0 / 100));
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
