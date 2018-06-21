using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_11_LogsAggregator
{
    public class logsAggregator
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the log information from the console.
        static void ReceiveInput()
        {
            var userList = new SortedDictionary<string, User>();
            var numberOfLogs = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfLogs; index++)
            {
                var log = Console.ReadLine();
                ProcessLog(log, userList);
            }

            Print(userList);
        }

        //Process the incoming logs.
        static void ProcessLog(string log, SortedDictionary<string, User> userList)
        {
            var temp = log.Split(' ');
            var user = temp[1];
            var ip = temp[0];
            var duration = int.Parse(temp[2]);

            CreateRecord(user, ip, duration, userList);
        }

        //Creates a rocord of the incoming ips.
        static void CreateRecord(string user, string ip, int duration, SortedDictionary<string, User> userList)
        {
            if (!userList.ContainsKey(user))
            {
                User newUser = new User();
                newUser.Ip = new SortedSet<string>();
                newUser.Ip.Add(ip);
                newUser.TotalDuration += duration;
                userList.Add(user, newUser);
            }
            else if (userList.ContainsKey(user) && !userList[user].Ip.Contains(ip))
            {
                userList[user].Ip.Add(ip);
                userList[user].TotalDuration += duration;
            }
            else if (userList.ContainsKey(user) && userList[user].Ip.Contains(ip))
            {
                userList[user].TotalDuration += duration;
            }
        }

        //Prints the sorted logs.
        static void Print(SortedDictionary<string, User> userList)
        {
            var output = "[";

            foreach (var user in userList)
            {
                foreach (var ip in user.Value.Ip)
                {
                    if (ip == user.Value.Ip.Last())
                    {
                        output += ip + "]";
                    }
                    else
                    {
                        output += ip + ", ";
                    }
                }

                Console.WriteLine($"{user.Key}: {user.Value.TotalDuration} {output}");
                output = "[";
            }
        }
    }

    //Creates object newUser.
    public class User
    {
        private SortedSet<string> ip;
        private int totalDuration;

        public SortedSet<string> Ip
        {
            get
            {
                return this.ip;
            }
            set
            {
                this.ip = value;
            }
        }

        public int TotalDuration
        {
            get
            {
                return this.totalDuration;
            }
            set
            {
                this.totalDuration = value;
            }
        }

        public User()
        {
            this.ip = Ip;
            this.totalDuration += TotalDuration;
        }
    }
}