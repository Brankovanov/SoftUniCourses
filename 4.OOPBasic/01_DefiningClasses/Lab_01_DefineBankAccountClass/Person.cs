using System.Collections.Generic;
using System.Linq;

namespace Lab_01_DefineBankAccountClass
{
    //Creates a newPerson objects that hold the user name, age and list of his accounts. Also calculate the total balance of all accounts.
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

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
            : this(name, age, new List<BankAccount>())
        { }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public decimal GetBalance()
        {
            return this.accounts.Select(acc => acc.Balance).Sum();
        }
    }
}