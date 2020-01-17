namespace Ex_01_Person
{
    public class Citizen : IPerson,IBirthable,IIdentifiable
    {
        private string name;
        private int age;
        private string birthDate;
        private string id;

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

        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;

            }
        }

        public string Id
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

        public Citizen(string name, int age, string birthDay, string id)
        {
            this.Age = age;
            this.Name = name;
            this.BirthDate = birthDay;
            this.Id = id;
        }
    }
}
