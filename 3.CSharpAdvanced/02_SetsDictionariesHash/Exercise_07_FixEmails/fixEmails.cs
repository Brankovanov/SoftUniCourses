using System;
using System.Collections.Generic;

namespace Exercise_07_FixEmails
{
    public class fixEmails
    {
        public static void Main(string[] args)
        {
            ReceiveEmails();
        }

        //Receives usernames and emails from the console.
        static void ReceiveEmails()
        {
            var emailRecord = new Dictionary<string, string>();
            var name = Console.ReadLine();
            var email = Console.ReadLine();

            while (name != "stop")
            {
                if (!email.ToLower().EndsWith("us"))
                {
                    if (!email.ToLower().EndsWith("uk"))
                    {
                        CreateEntry(emailRecord, name, email);
                    }
                }

                name = Console.ReadLine();

                if (name != "stop")
                {
                    email = Console.ReadLine();
                }
            }

            Print(emailRecord);
        }

        //Creates new entry in the record.
        static void CreateEntry(Dictionary<string, string> emailRecord, string name, string email)
        {
            if (!emailRecord.ContainsKey(name))
            {
                emailRecord.Add(name, email);
            }
            else
            {
                emailRecord[name] = email;
            }
        }

        //Print the recorded users and emails.
        static void Print(Dictionary<string, string> emailRecord)
        {
            foreach (var user in emailRecord)
            {
                Console.Write($"{user.Key} -> {user.Value}");
                Console.WriteLine();
            }
        }
    }
}