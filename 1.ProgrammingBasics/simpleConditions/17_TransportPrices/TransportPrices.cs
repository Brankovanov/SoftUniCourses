using System;

namespace _17_TransportPrices
{
    public class TransportPrices
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var distance = double.Parse(Console.ReadLine());
            var partOfTheDay = Console.ReadLine();

            CalculateCheapestTransport(distance, partOfTheDay);    
        }

        //Chooses the type transport. 
        static void CalculateCheapestTransport(double distance, string partOfTheDay)
        {
            var transportPrice = 0.0;

            if(distance>=100)
            {
              transportPrice=  CalculateTrainTicket(distance);
            }
            else if (distance>=20 && distance<=99)
            {
               transportPrice=  CalculateBusTicket(distance);
            }
            else
            {
                transportPrice = CalculateTaxiPrice(distance, partOfTheDay);
            }

            PrintCheapestPrice(transportPrice);
        }

        //Calculates the price of the train ticket.
        static double CalculateTrainTicket(double distance)
        {
            return distance * 0.06;
        }

        //Calculates the price of the bus ticket.
        static double CalculateBusTicket(double distance)
        {
            return distance * 0.09;
        }

        //Calculates the price for the taxi.
        static double CalculateTaxiPrice(double distance, string partOfTheday)
        {
            if(partOfTheday.Equals("day"))
            {
                return 0.7 + (distance * 0.79);
            }
            else
            {
                return 0.7 + (distance * 0.9);
            }
        }

        //Prints the lowest price for transport.
        static void PrintCheapestPrice(double transportPrice)
        {
            Console.WriteLine(transportPrice);
        }
    }
}