using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_13_ConcertVenues
{
    public class concertVenues
    {
        public static void Main(string[] args)
        {
            ReceiveConcertInformation();
        }

        //Receives information for the concerts from the console.
        static void ReceiveConcertInformation()
        {
            var venueRecord = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                CheckConcertInformation(input, venueRecord);
                input = Console.ReadLine();
            }

            PrintVenueInformation(venueRecord);
        }


        //Checks if input coresponds to the requirements.
        static void CheckConcertInformation(string input, Dictionary<string, Dictionary<string, long>> venueRecord)
        {
            var temp = new string[2];

            if (input.Contains(" @"))
            {
                temp = input.Replace(" @", "|").Split('|');
            }
            else
            {
                return;
            }

            var singer = temp[0].Trim();

            if (singer.Split(' ').Length > 3)
            {
                return;
            }

            var concertInformation = temp[1];
            RetrieveConcertInformation(singer, concertInformation, venueRecord);
        }

        //Process the consert information. 
        static void RetrieveConcertInformation(string singer, string concertInformation, Dictionary<string, Dictionary<string, long>> venueRecord)
        {
            var countOfTickets = 0l;
            var ticketPrice = 0l;
            var venue = string.Empty;
            var temp = concertInformation.Split(' ');

            try
            {
                countOfTickets = long.Parse(temp[temp.Length - 1]);
                ticketPrice = long.Parse(temp[temp.Length - 2]);
            }
            catch
            {
                return;
            }

            if (temp.Length - 2 <= 3)
            {
                for (var index = 0; index <= temp.Length - 3; index++)
                {
                    venue += temp[index] + " ";
                }
            }
            else
            {
                return;
            }

            RecordValid(singer, venue, countOfTickets, ticketPrice, venueRecord);
        }

        //Records the valid inputs.
        static void RecordValid(string singer, string venue, long countOfTickets, long ticketPrice, Dictionary<string, Dictionary<string, long>> venueRecord)
        {
            var totalPrice = countOfTickets * ticketPrice;

            if (!venueRecord.ContainsKey(venue))
            {
                venueRecord.Add(venue, new Dictionary<string, long>());
                venueRecord[venue].Add(singer, totalPrice);
            }
            else if (venueRecord.ContainsKey(venue) && !venueRecord[venue].ContainsKey(singer))
            {
                venueRecord[venue].Add(singer, totalPrice);
            }
            else if (venueRecord.ContainsKey(venue) && venueRecord[venue].ContainsKey(singer))
            {
                venueRecord[venue][singer] += totalPrice;
            }
        }

        //Prints the recorded venue information.
        static void PrintVenueInformation(Dictionary<string, Dictionary<string, long>> venueRecord)
        {
            foreach (var venue in venueRecord)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}