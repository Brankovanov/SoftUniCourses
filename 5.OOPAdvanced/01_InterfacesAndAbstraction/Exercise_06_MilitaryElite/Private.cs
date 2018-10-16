namespace Exercise_06_MilitaryElite
{
    //Class private derived from the IPrivate interface.
    public class Private : IPrivate
    {
        private double salary;
        private string id;
        private string firstName;
        private string lastName;

        public double Salary
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

        public Private(string id, string firstName, string lastName, double salary)
        {
            this.Salary = salary;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.firstName} {this.lastName} Id: {this.id} Salary: {string.Format("{0:0.00}", this.salary)} ";
        }
    }
}