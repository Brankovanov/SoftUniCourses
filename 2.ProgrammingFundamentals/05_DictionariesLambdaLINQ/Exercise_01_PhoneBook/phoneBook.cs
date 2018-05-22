using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_01_PhoneBook
{
    public class phoneBook
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            List<string> listOfCommands = new List<string>();

            var receiveCommands = Console.ReadLine();
            listOfCommands.Add(receiveCommands);

            while (receiveCommands != "END")
            {
                receiveCommands = Console.ReadLine();
                listOfCommands.Add(receiveCommands);
            }

            ExecuteCommands(listOfCommands);
        }

        static void ExecuteCommands(List<string> listOfCommands)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            List<string> commands = new List<string>();
            var name = string.Empty;
            var phone = string.Empty;

            foreach (var comm in listOfCommands)
            {
                if (comm != "END")
                {
                    commands = comm.Split(' ').ToList();
                    name = commands[1].ToString();

                    if (commands[0].Equals("A"))
                    {
                        phone = commands[2].ToString();
                        CreatePhoneBook(phoneBook, phone, name);
                    }
                    else if (commands[0].Equals("S"))
                    {
                        Search(phoneBook, name);
                    }
                }
            }
        }

        static void CreatePhoneBook(Dictionary<string, string> phoneBook, string phone, string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                phoneBook[name] = phone;
            }
            else
            {
                phoneBook.Add(name, phone);
            }
        }

        static void Search(Dictionary<string, string> phoneBook, string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine(name + " -> " + phoneBook[name]);
            }
            else
            {
                Console.WriteLine("Contact " + name + " does not exist.");
            }
        }
    }
}