using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_10_ConcertVenues
{
    public class concertVenues
    {
        public static void Main(string[] args)
        {
            ReceiveVenues();
        }

        static void ReceiveVenues()
        {
            Dictionary<string, Dictionary<string, int>> concertInformation = new Dictionary<string, Dictionary<string, int>>();
            List<string> listOfConcerts = new List<string>();
            var venues = Console.ReadLine();
            listOfConcerts.Add(venues);

            while (venues != "End")
            {
                venues = Console.ReadLine();
                listOfConcerts.Add(venues);
            }

            listOfConcerts.Remove("End");
            ProccessVenues(listOfConcerts, concertInformation);
            Print(concertInformation);
        }

        static void ProccessVenues(List<string> listOfConcerts, Dictionary<string, Dictionary<string, int>> concertInformation)
        {
            List<string> temp = new List<string>();
            List<string> temporary = new List<string>();
            var name = string.Empty;
            var concertHall = string.Empty;
            var ticketCount = string.Empty;
            var ticketPrice = string.Empty;

            foreach (var concert in listOfConcerts)
            {
                temp = concert.Split('@').ToList();
                temporary.RemoveAll(x => x == string.Empty);
                name = temp[0];
                temporary = temp[1].Split(' ').ToList();
                ticketCount = (temporary[temporary.Count - 1]);
                temporary.Remove(temporary[temporary.Count - 1]);

                try
                {
                    ticketPrice = (temporary[temporary.Count - 1]);
                    temporary.Remove(temporary[temporary.Count - 1]);
                }
                catch (KeyNotFoundException)
                {
                }

                foreach (var remaining in temporary)
                {
                    concertHall += remaining + " ";
                }

                concertHall.Replace('@', ' ');
                SortConcerts(name, ticketCount, ticketPrice, concertHall, concertInformation);

                name = string.Empty;
                ticketCount = string.Empty;
                ticketPrice = string.Empty;
                concertHall = string.Empty;
                temp.Clear();
                temporary.Clear();
            }
        }

        static void SortConcerts(string name, string ticketCount, string ticketPrice, string concertHall, Dictionary<string, Dictionary<string, int>> concertInformation)
        {
            var totalPrice = 0;

            try
            {
                totalPrice = int.Parse(ticketCount) * int.Parse(ticketPrice);
            }
            catch (FormatException)
            {
                return;
            }

            if (!concertInformation.ContainsKey(concertHall))
            {
                concertInformation[concertHall] = new Dictionary<string, int>();
            }

            if (!concertInformation[concertHall].ContainsKey(name))
            {
                concertInformation[concertHall][name] = totalPrice;
            }
            else
            {
                concertInformation[concertHall][name] += totalPrice;
            }

            totalPrice = 0;
        }

        static void Print(Dictionary<string, Dictionary<string, int>> concertInformation)
        {
            

            foreach (var hall in concertInformation)
            {
                if (!string.IsNullOrEmpty(hall.Key))
                {
                    Console.WriteLine(hall.Key);

                    foreach (var singer in hall.Value.OrderByDescending(k => k.Value))
                    {
                        if (!string.IsNullOrEmpty(singer.Key))
                        {
                            Console.WriteLine("#  " + singer.Key + "-> " + singer.Value);
                        }

                    }
                }
            }
        }
    }
}



//POPRAVKA
