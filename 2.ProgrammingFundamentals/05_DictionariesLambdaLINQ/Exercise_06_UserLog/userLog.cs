using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_UserLog
{
    public class userLog
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            List<string> listOfInputs = new List<string>();

            var input = Console.ReadLine();
            listOfInputs.Add(input);

            while (input != "end")
            {
                input = Console.ReadLine();
                listOfInputs.Add(input);
            }

            listOfInputs.Remove("end");
            CreateUsers(listOfInputs);
        }

        static void CreateUsers(List<string> listOfInputs)
        {
            List<string> tempList = new List<string>();
            var userName = string.Empty;
            var ipAdress = string.Empty;
            var message = string.Empty;

            SortedDictionary<string, Dictionary<string, int>> userLog = new SortedDictionary<string, Dictionary<string, int>>();

            foreach (var entry in listOfInputs)
            {
                tempList = entry.Split(' ').ToList();

                userName = tempList[2].Remove(0, 5);
                message = tempList[1].Remove(0, 8);
                ipAdress = tempList[0].Remove(0, 3);

                if (!userLog.ContainsKey(userName))
                {
                    userLog[userName] = new Dictionary<string, int>();
                }

                if(!userLog[userName].ContainsKey(ipAdress))
                {
                    userLog[userName][ipAdress] = 0;
                }

                userLog[userName][ipAdress]++;
            }

            foreach (var user in userLog)
            {
                Console.WriteLine(user.Key + ": ");

                foreach (var ip in user.Value)
                {
                    if (ip.Key != user.Value.Keys.Last())
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


