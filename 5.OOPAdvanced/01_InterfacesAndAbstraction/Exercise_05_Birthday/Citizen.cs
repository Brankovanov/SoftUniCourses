namespace Exercise_05_Birthday
{
    //Derived class from the IBorn interface. Holds the citizen's name, id and age.
    public class Citizen : IBorn
    {
        private string name;
        private string id;
        private int age;
        private string birthDate;

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
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

        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            private set
            {
                this.birthDate = value;
            }
        }

        public Citizen(string name, string id, int age, string birthDate)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.BirthDate = birthDate;
        }
    }
}