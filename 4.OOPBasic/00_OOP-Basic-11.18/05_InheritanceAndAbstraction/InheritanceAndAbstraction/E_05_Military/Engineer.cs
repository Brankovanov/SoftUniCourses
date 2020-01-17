
using System;
using System.Collections.Generic;

namespace E_05_Military
{
    public class Engineer : Soldier,ISpecializedSoldier, IEngineer, IPrivate
    {
        private decimal salary;
        private Dictionary<string, int> repairs;
        private string corps;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public Dictionary<string, int> Repairs
        {
            get
            {
                return this.repairs;
            }
            set
            {
                this.repairs = value;
            }
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }
            set
            {
                this.corps = value;
            }
        }

        public Engineer(string id, string firstName, string lastName, decimal salary,string corps)

            :base(id,firstName,lastName)
        {
            this.Corps = corps;
            this.Salary = salary;
            this.Repairs = new Dictionary<string, int>();

        }

        public override string ToString()
        {
            var outPut = base.ToString() + $" Salary: {this.Salary} " + Environment.NewLine +
                 $"Corps: {this.Corps} " + Environment.NewLine +
             "Repairs:" + Environment.NewLine;

            foreach (var repair in this.Repairs)
            {
                outPut += "Name: "+ repair.Key + Environment.NewLine + "Status: " +repair.Value + Environment.NewLine;
            }

            return outPut;
        }
    }
}
