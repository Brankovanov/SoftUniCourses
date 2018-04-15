using System;

namespace _18_HotelRoom
{
    public class hotelRoom
    {
        public static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studio = 0.0;
            var flat = 0.0;

            if (month.Equals("May") || month.Equals("October"))
            {

                if (nights > 14)
                {
                    flat = (nights * (65 - (65 * 0.1)));
                    Console.WriteLine("Apartment: " + string.Format("{0:0.00}", flat) + " lv.");
                }
                else
                {
                    flat = nights * 65;
                    Console.WriteLine("Apartment: " + string.Format("{0:0.00}", flat) + " lv.");
                }

                if (nights > 7)
                {
                    studio = nights * (50 - (50 * 0.05));
                    Console.WriteLine("Studio: " + string.Format("{0:0.00}", studio) + " lv.");
                }
                else if (nights > 14)
                {
                    studio = nights * (50 - (50 * 0.3));
                    Console.WriteLine("Studio: " + string.Format("{0:0.00}", studio) + " lv.");
                }
                else
                {
                    studio = nights * 50;
                    Console.WriteLine("Studio: " + string.Format("{0:0.00}", studio) + " lv.");
                }

            }
            else if (month.Equals("June") || month.Equals("September"))
            {

                if (nights > 14)
                {
                    flat = nights * (68.7 - (68.7 * 0.1));
                    Console.WriteLine("Apartment: " + string.Format("{0:0.00}", flat) + " lv.");
                }
                else
                {
                    flat = nights * 68.7;
                    Console.WriteLine("Apartment: " + string.Format("{0:0.00}", flat) + " lv.");
                }

                if (nights > 14)
                {
                    studio = nights * (75.2 - (75.2 * 0.2));
                    Console.WriteLine("Studio: " + string.Format("{0:0.00}", studio) + " lv.");
                }
                else
                {
                    studio = nights * 75.2;
                    Console.WriteLine("Studio: " + string.Format("{0:0.00}", studio) + " lv.");
                }

            }
            else if (month.Equals("July") || month.Equals("August"))
            {
                if (nights > 14)
                {
                    flat = nights * (77 - (77 * 0.1));
                    Console.WriteLine("Apartment: " + string.Format("{0:0.00}", flat) + " lv.");
                }
                else
                {
                    flat = nights * 77;
                    Console.WriteLine("Apartment: " + string.Format("{0:0.00}", flat) + " lv.");
                }

                studio = nights * 76;
                Console.WriteLine("Studio: " + string.Format("{0:0.00}", studio) + " lv.");
            }
        }
    }
}
