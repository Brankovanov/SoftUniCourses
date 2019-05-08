using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
   public  class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();

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

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public List<BankAccount> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts.AddRange(accounts);
        }

        public decimal GetBalance()
        {
            var sum = 0.0m;
            foreach (var account in accounts)
            {
                sum += account.Balance;
            }

            return sum;
        }
    }
}

