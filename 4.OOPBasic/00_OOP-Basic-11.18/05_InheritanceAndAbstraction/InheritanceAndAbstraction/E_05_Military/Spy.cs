using System;
using System.Collections.Generic;
using System.Text;

namespace E_05_Military
{
    public class Spy : Soldier, ISpy
    {
        private int codeNumber;
        public int CodeNumber
        {
            get
            {
                return this.codeNumber;
            }
            set
            {
                this.codeNumber = value;
            }
        }

        public Spy(string id, string firstName, string lastName, int codeNumber)
            :base(id,firstName,lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $" Code number: {this.CodeNumber}";

        }
    }
}
