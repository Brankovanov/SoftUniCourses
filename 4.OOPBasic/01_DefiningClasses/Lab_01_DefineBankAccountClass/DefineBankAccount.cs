using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01_DefineBankAccountClass
{
    public class DefineBankAccount
    {
        public static void Main()
        {
            var bankArchive = new List<BankAccount>();
            ReceiveCommands(bankArchive);
        }

        //Receives commands from the console.
        public static void ReceiveCommands(List<BankAccount> bankArchive)
        {
            var command = Console.ReadLine();

            while (command != "End")
            {
                ExecuteCommands(command, bankArchive);
                command = Console.ReadLine();
            }
        }

        //Executes the commands received from the console.
        public static void ExecuteCommands(string command, List<BankAccount> bankArhive)
        {
            var temp = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var comm = temp[0];

            switch (comm)
            {
                case "Create":

                    if (temp.Length != 2)
                    {
                        Console.WriteLine("Invalid command.");
                    }
                    else
                    {
                        var validIdentificator = int.TryParse(temp[1], out int identificator);

                        if (validIdentificator)
                        {
                            CreateBankAccount(bankArhive, identificator);
                        }
                        else
                        {
                            Console.WriteLine("Invalid command.");
                        }
                    }

                    break;

                case "Deposit":

                    if (temp.Length != 3)
                    {
                        Console.WriteLine("Invalid command.");
                    }
                    else
                    {
                        var validIdentificator = int.TryParse(temp[1], out int identificator);
                        var validAmount = decimal.TryParse(temp[2], out decimal amount);

                        if (validIdentificator && validAmount)
                        {
                            Deposit(bankArhive, identificator, amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid command.");
                        }
                    }

                    break;

                case "Withdraw":

                    if (temp.Length != 3)
                    {
                        Console.WriteLine("Invalid command.");
                    }
                    else
                    {
                        var validIdentificator = int.TryParse(temp[1], out int identificator);
                        var validAmount = decimal.TryParse(temp[2], out decimal amount);

                        if (validIdentificator && validAmount)
                        {
                            Withdraw(bankArhive, identificator, amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid command.");
                        }
                    }

                    break;

                case "Print":

                    if (temp.Length != 2)
                    {
                        Console.WriteLine("Invalid command.");
                    }
                    else
                    {
                        var validIdentificator = int.TryParse(temp[1], out int identificator);

                        if (validIdentificator)
                        {
                            PrintTheBankAccountDetails(bankArhive, identificator);
                        }
                        else
                        {
                            Console.WriteLine("Invalid command.");
                        }
                    }

                    break;

                default:

                    Console.WriteLine("Invalid command.");

                    break;
            }
        }

        //Creates object newBankAccount.
        public static void CreateBankAccount(List<BankAccount> bankArchive, int identificator)
        {
            if (bankArchive.Any(a => a.Id == identificator))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var newBankAccount = new BankAccount();
                newBankAccount.Id = identificator;
                bankArchive.Add(newBankAccount);
            }
        }

        //Deposits in the bank account.
        public static void Deposit(List<BankAccount> bankArchive, int identificator, decimal amount)
        {
            if (bankArchive.Any(a => a.Id == identificator))
            {
                bankArchive.First(n => n.Id == identificator).Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        //Withdraws from the bank account.
        public static void Withdraw(List<BankAccount> bankArchive, int identificator, decimal amount)
        {
            if (bankArchive.Any(a => a.Id == identificator))
            {
                bankArchive.First(n => n.Id == identificator).Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        //Prints the bankaccount details on the console.
        public static void PrintTheBankAccountDetails(List<BankAccount> bankArchive, int identificator)
        {
            if (bankArchive.Any(a => a.Id == identificator))
            {
                Console.WriteLine($"Account ID{bankArchive.First(n => n.Id == identificator).Id}, balance {string.Format("{0:0.00}", bankArchive.First(n => n.Id == identificator).Balance)}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }
    }
}