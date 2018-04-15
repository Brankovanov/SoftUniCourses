using System;

namespace _02_SmallShop
{
    public class smallShop
    {
        public static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (product.Equals("coffee"))
            {
                if (city.Equals("Sofia"))
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (city.Equals("Plovdiv"))
                {
                    Console.WriteLine(quantity * 0.4);
                }
                else if (city.Equals("Varna"))
                {
                    Console.WriteLine(quantity * 0.45);
                }
            }
            else if (product.Equals("water"))
            {
                if (city.Equals("Sofia"))
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (city.Equals("Plovdiv"))
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (city.Equals("Varna"))
                {
                    Console.WriteLine(quantity * 0.7);
                }
            }
            else if (product.Equals("beer"))
            {
                if (city.Equals("Sofia"))
                {
                    Console.WriteLine(quantity * 1.2);
                }
                else if (city.Equals("Plovdiv"))
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (city.Equals("Varna"))
                {
                    Console.WriteLine(quantity * 1.1);
                }
            }
            else if (product.Equals("sweets"))
            {
                if (city.Equals("Sofia"))
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (city.Equals("Plovdiv"))
                {
                    Console.WriteLine(quantity * 1.3);
                }
                else if (city.Equals("Varna"))
                {
                    Console.WriteLine(quantity * 1.35);
                }
            }
            else if (product.Equals("peanuts"))
            {
                if (city.Equals("Sofia"))
                {
                    Console.WriteLine(quantity * 1.6);
                }
                else if (city.Equals("Plovdiv"))
                {
                    Console.WriteLine(quantity * 1.5);
                }
                else if (city.Equals("Varna"))
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }
}
