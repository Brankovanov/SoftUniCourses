using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_10_PredicateParty
{
    public class PredicateParty
    {
        public static void Main(string[] args)
        {
            ReceiveGuests();
        }

        //Receive guestlist and commands from the console.
        public static void ReceiveGuests()
        {
            var guestList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine();

            while (commands != "Party!")
            {
                ExecuteCommands(commands, guestList);
                commands = Console.ReadLine();
            }

            Print(guestList);
        }

        //Executes the given commands.
        public static void ExecuteCommands(string commands, List<string> guestList)
        {
            var temp = commands.Split(' ');
            var type = temp[0];
            var action = temp[1];
            var criterium = temp[2];
            var temporary = new List<string>();

            Predicate<string> command = s => s.StartsWith("Remove");
            Predicate<string> actionType = a => a.EndsWith("With");
            Predicate<string> startEnd = e => e.StartsWith("Starts");

            if (command(type))
            {
                if (actionType(action))
                {
                    if (startEnd(action))
                    {
                        guestList.RemoveAll(r => r.StartsWith(criterium));
                    }
                    else
                    {
                        guestList.RemoveAll(r => r.EndsWith(criterium));
                    }
                }
                else
                {
                    guestList.RemoveAll(l => l.Length == int.Parse(criterium));
                }
            }
            else
            {
                if (actionType(action))
                {
                    if (startEnd(action))
                    {
                        temporary = guestList.Where(r => r.StartsWith(criterium)).ToList();
                    }
                    else
                    {
                        temporary = guestList.Where(r => r.EndsWith(criterium)).ToList();
                    }
                }
                else
                {
                    temporary = guestList.Where(r => r.Length == int.Parse(criterium)).ToList();
                }
            }

            guestList.AddRange(temporary);
        }

        //Prints the final quest list.
        public static void Print(List<string> guestList)
        {
            if (guestList.Count > 0)
            {
                Console.WriteLine(string.Join(", ", guestList) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}