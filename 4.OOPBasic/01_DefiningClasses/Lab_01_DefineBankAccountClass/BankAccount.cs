using System;

namespace Lab_01_DefineBankAccountClass
{
    //Creates bank account objects that hold user id and account ballace. Calculates the balance when the user deposit ot withdraw money.
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        //Calculates the balance when deposit.
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount negative!");
            }
        }

        //Calculates the balance when we withdraw.
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }
    }
}
