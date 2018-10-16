using System;

namespace Exercise_06_MilitaryElite
{
    //Class spy derived from the ISpy interface.
    public class Spy : ISpy
    {
        private string id;
        private string firstName;
        private string lastName;
        private int code;

        public int Code
        {
            get
            {
                return this.code;
            }
            private set
            {
                this.code = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }

        public Spy(int code, string id, string firstName, string lastName)
        {
            this.Code = code;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.firstName} {this.lastName} Id: {this.id}{Environment.NewLine}" +
                $"Code Number: {this.code}";
        }
    }
}