using System;

namespace _04_HotelReservation
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var input = Console.ReadLine();
            var temp = input.Split(' ');
            var price = double.Parse(temp[0]);
            var days = int.Parse(temp[1]);
            var season = temp[2];
            var discount = temp[3];


            CreateReservation(price, days, season, discount);
        }

        public static void CreateReservation(double price, int days, string season, string discount)
        {

            var seasonCode = 0;
            var discountPercentage = 0;

            switch (season)
            {
                case "Autumn":
                    seasonCode =(int) Season.Autumn;
                    break;

                case "Spring":
                    seasonCode = (int)Season.Spring;
                    break;

                case "Winter":
                    seasonCode = (int)Season.Winter;
                    break;

                case "Summer":
                    seasonCode = (int)Season.Summer;
                    break;
            }

            switch (discount)
            {
                case "VIP":
                    discountPercentage = (int)Discount.VIP;
                    break;

                case "SecondVisit":
                    discountPercentage = (int)Discount.SecondVisit;
                    break;

                case "None":
                    discountPercentage = (int)Discount.None;
                    break;
            }

            var res = new Reservation(price, days, seasonCode, discountPercentage);
          


           Calculate(res);
        }

        public static void Calculate(Reservation res)
        {
            Console.WriteLine(string.Format("{0:0.00}", Calculator.Calculate(res)));
        }
    }
}
