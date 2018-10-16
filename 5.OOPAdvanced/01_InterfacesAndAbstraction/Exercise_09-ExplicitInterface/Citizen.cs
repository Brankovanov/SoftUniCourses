namespace Exercise_09_ExplicitInterface
{
    //Class Citizen derived from IPerson and IResident interfaces.
    public class Citizen : IPerson, IResident
    {
        private string country;
        private string name;
        private int age;

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }

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

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.name}";
        }

        string IPerson.GetName()
        {
            return $"{this.name}";
        }
    }
}