using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_07_SoftUniParty
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CreateReservationList();
        }

        private static void CreateReservationList()
        {
            var input = Console.ReadLine();
            var reservationList = new HashSet<string>();

            while (input != "PARTY")
            {
                reservationList.Add(input);

                input = Console.ReadLine();
            }

            PartyHard(reservationList);
        }

        private static void PartyHard(HashSet<string> reservationList)
        {
            var arrivingQuests = Console.ReadLine();

            while (arrivingQuests != "END")
            {
                reservationList.Remove(arrivingQuests);

                arrivingQuests = Console.ReadLine();
            }

            Aftermath(reservationList);
        }

        private static void Aftermath(HashSet<string> reservationList)
        {
            Console.WriteLine(reservationList.Count);
            foreach (var guest in reservationList.OrderByDescending(g => char.IsDigit(g[0])))
            {
                Console.WriteLine(guest);
            }

        }
    }
}
