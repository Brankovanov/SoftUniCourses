using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_08_RoliTheCoder
{
    public class roliTheCoder
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var listOfEvent = new Dictionary<string, Event>();
            var eventTemp = new List<string>();
            var input = Console.ReadLine();

            while (input != "Time for Code")
            {
                eventTemp = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToList();
                CheckEntry(eventTemp, listOfEvent);
                input = Console.ReadLine();
            }

            PrintEvent(listOfEvent);
        }

        //Check if the entry is in the correct format.
        static void CheckEntry(List<string> eventTemp, Dictionary<string, Event> listOfEvent)
        {
            var eventId = eventTemp[0];
            var eventName = eventTemp[1];
            var participant = string.Empty;

            if (eventName.StartsWith("#"))
            {
                var participantsList = new List<String>();

                for (var ind = 2; ind <= eventTemp.Count - 1; ind++)
                {
                    participant = eventTemp[ind];

                    if (participant.StartsWith("@") && !participantsList.Contains(participant))
                    {
                        participantsList.Add(participant);
                        participant = string.Empty;
                    }
                    else if (!participant.StartsWith("@"))
                    {
                        participant = string.Empty;
                        participantsList.Clear();
                        return;
                    }
                }

                CreateEvent(participantsList, eventId, eventName, listOfEvent);
            }
            else
            {
                return;
            }
        }

        //Create a new event or update the existing ones.
        static void CreateEvent(List<string> participantList, string eventId, string eventName, Dictionary<string, Event> listOfEvent)
        {
            if (listOfEvent.ContainsKey(eventId) && listOfEvent[eventId].Name.Equals(eventName))
            {
                listOfEvent[eventId].Participants.AddRange(participantList);
                listOfEvent[eventId].Participants = listOfEvent[eventId].Participants.Distinct().ToList();
            }
            else if (listOfEvent.ContainsKey(eventId) && !listOfEvent[eventId].Name.Equals(eventName))
            {
                return;
            }
            else if (!listOfEvent.ContainsKey(eventId))
            {
                Event newEvent = new Event();
                newEvent.Name = eventName;
                newEvent.Participants = participantList;
                listOfEvent[eventId] = newEvent;
            }
        }

        //Отпечава списъка със събития и участници.
        static void PrintEvent(Dictionary<string, Event> listOfEvent)
        {
            foreach (var happening in listOfEvent.OrderByDescending(x => x.Value.Participants.Count).ThenBy(y => y.Value.Name))
            {
                Console.WriteLine(happening.Value.Name.TrimStart('#') + " - " + happening.Value.Participants.Count);

                foreach (var person in happening.Value.Participants.OrderBy(z => z))
                {
                    Console.WriteLine(person);
                }
            }
        }
    }

    //Class Event that creates objects newEvents. 
    public class Event
    {
        private string name;
        private List<string> participants;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public List<string> Participants
        {
            get
            {
                return this.participants;
            }
            set
            {
                this.participants = value;
            }
        }

        public Event()
        {
            this.name = Name;
            this.participants = Participants;
        }
    }
}