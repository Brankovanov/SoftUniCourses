using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_09_UserLogs
{
    public class userLogs
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives information from the console.
        static void ReceiveInput()
        {
            var recordedMessages = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                ProcessInput(input, recordedMessages);
                input = Console.ReadLine();
            }

            Print(recordedMessages);
        }

        //Process the input from the console.
        static void ProcessInput(string input, SortedDictionary<string, Dictionary<string, int>> recordedMessages)
        {
            var temp = input.Split(' ');
            var name = temp[2].Remove(0, 5);
            var ip = temp[0].Remove(0, 3);

            CreateEntry(name, ip, recordedMessages);
        }

        //Creates or updates the entries in recordedMessages
        static void CreateEntry(string name, string ip, SortedDictionary<string, Dictionary<string, int>> recordedMessages)
        {
            if (recordedMessages.ContainsKey(name) && recordedMessages[name].ContainsKey(ip))
            {
                recordedMessages[name][ip]++;
            }
            else if (recordedMessages.ContainsKey(name) && !recordedMessages[name].ContainsKey(ip))
            {
                recordedMessages[name].Add(ip, 1);
            }
            else if (!recordedMessages.ContainsKey(name))
            {
                recordedMessages.Add(name, new Dictionary<string, int>());
                recordedMessages[name].Add(ip, 1);
            }
        }

        //Prints the recorded entries.
        static void Print(SortedDictionary<string, Dictionary<string, int>> recordedMessages)
        {
            var output = string.Empty;

            foreach (var player in recordedMessages)
            {
                Console.WriteLine(player.Key + ": ");

                foreach (var ip in player.Value)
                {
                    if (ip.Key != player.Value.Keys.Last())
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ", ");
                    }
                    else
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ". ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}