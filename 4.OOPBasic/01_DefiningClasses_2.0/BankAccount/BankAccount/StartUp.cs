using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccount
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveCommands();
        }

        public static void ReceiveCommands()
        {
            var accountList = new Dictionary<int,BankAccount>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                if (command.StartsWith("Create"))
                {
                    var temp = command.Split(' ');
                    var id = int.Parse(temp[1]);
                    CreateAccount(accountList, id);
                }
                else if (command.StartsWith("Deposit"))
                {
                    var temp = command.Split(' ');
                    var id = int.Parse(temp[1]);
                    var amount = int.Parse(temp[2]);
                    Deposit(accountList, id, amount);
                }
                else if (command.StartsWith("Withdraw"))
                {
                    var temp = command.Split(' ');
                    var id = int.Parse(temp[1]);
                    var amount = int.Parse(temp[2]);
                    Withdraw(accountList, id, amount);
                }
                else if (command.StartsWith("Print"))
                {
                    var temp = command.Split(' ');
                    var id = int.Parse(temp[1]);
                    Print(accountList, id);
                }

                command = Console.ReadLine();
            }
        }

        public static void CreateAccount(Dictionary<int,BankAccount> accountList,int id)
        {
            if (accountList.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var newAccount = new BankAccount(id);
                accountList.Add(id, newAccount);
            }
        }

        public static void Deposit(Dictionary<int, BankAccount> accountList, int id, int amount)
        {
            if (accountList.ContainsKey(id))
            {
                accountList[id].Balance += amount;
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }


        public static void Withdraw(Dictionary<int, BankAccount> accountList, int id,int amount)
        {
            if (accountList.ContainsKey(id) && accountList[id].Balance >= amount)
            {
                accountList[id].Balance -= amount;
            }
            else if (accountList.ContainsKey(id) && accountList[id].Balance< amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        public static void Print(Dictionary<int, BankAccount> accountList, int id)
        {
            if (accountList.ContainsKey(id))
            {
                Console.WriteLine($"Account ID{id}, balance {accountList[id].Balance}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }
    }
}
