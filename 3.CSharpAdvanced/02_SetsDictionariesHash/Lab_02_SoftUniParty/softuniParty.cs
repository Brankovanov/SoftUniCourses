using System;
using System.Collections.Generic;

namespace Lab_02_SoftUniParty
{
    public class softuniParty
    {
        public static void Main(string[] args)
        {
            ReceiveGuestList();
        }

        //Receives the list with the quests expected to come to the party from the console.
        static void ReceiveGuestList()
        {
            var guest = Console.ReadLine();
            var guestList = new SortedSet<string>();

            while (guest != "PARTY")
            {
                guestList.Add(guest);
                guest = Console.ReadLine();
            }

            ReceiveArrivingGuests(guestList);
        }

        //After the party starts receive the arriving guest from the console.
        static void ReceiveArrivingGuests(SortedSet<string> guestList)
        {
            var arrivingGuest = Console.ReadLine();

            while (arrivingGuest != "END")
            {
                if (guestList.Contains(arrivingGuest))
                {
                    guestList.Remove(arrivingGuest);
                }

                arrivingGuest = Console.ReadLine();
            }

            Print(guestList);
        }

        //Prints the guests that did not come to the party.
        static void Print(SortedSet<string> guestList)
        {
            Console.WriteLine(guestList.Count);

            foreach (var guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}