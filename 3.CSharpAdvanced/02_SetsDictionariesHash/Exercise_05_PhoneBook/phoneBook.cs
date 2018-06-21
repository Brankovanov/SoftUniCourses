using System;
using System.Collections.Generic;

namespace Exercise_05_PhoneBook
{
    public class phoneBook
    {
        public static void Main(string[] args)
        {
            ReceiveContacts();
        }

        //Receives contact information from the console.
        static void ReceiveContacts()
        {
            var phones = new Dictionary<string, string>();
            var contact = Console.ReadLine();

            while (!contact.Equals("search"))
            {
                RecordContacts(contact, phones);
                contact = Console.ReadLine();
            }

            var search = Console.ReadLine();

            while (!search.Equals("stop"))
            {
                SearchPhoneBook(search, phones);
                search = Console.ReadLine();
            }
        }

        //Records the new contacts or replaces the old number if the contact already exists.
        static void RecordContacts(string contact, Dictionary<string, string> phones)
        {
            var temp = contact.Split('-');
            var name = temp[0];
            var number = temp[1];

            if (phones.ContainsKey(name))
            {
                phones[name] = number;
            }
            else
            {
                phones.Add(name, number);
            }
        }

        //Search for contacts in the phonebook by name.
        static void SearchPhoneBook(string search, Dictionary<string, string> phones)
        {
            var output = string.Empty;

            if (phones.ContainsKey(search))
            {
                output = search + " -> " + phones[search];
            }
            else
            {
                output = $"Contact {search} a does not exist.";
            }

            Print(output);
        }

        //Prints the found contact.
        static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}