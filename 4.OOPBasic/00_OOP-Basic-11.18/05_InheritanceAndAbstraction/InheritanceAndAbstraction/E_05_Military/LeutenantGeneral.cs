using System;
using System.Collections.Generic;

namespace E_05_Military
{
    public class LeutenantGeneral : Soldier, ILeutenantGeneral,IPrivate
    {
        private List<Soldier> privates;
        private decimal salary;
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
        public List<Soldier> Privates
        {
            get
            {
                return this.privates;
            }
            set
            {
                this.privates = value;
            }
        }

        public LeutenantGeneral(string id, string firstName, string lastName,decimal salary)
            :base(id,firstName,lastName)
        {
            this.Salary = salary;
            this.Privates = new List<Soldier>();
        }

        public override string ToString()
        {
            var outPut = base.ToString() + $" Salary: {this.Salary} " + Environment.NewLine +
                
             "Privatese:" + Environment.NewLine;

            foreach (var privates in this.Privates)
            {
                try
                {
                    outPut += privates.ToString() + Environment.NewLine;
                }
                catch
                { }
            }

            return outPut;
        }
    }
}
