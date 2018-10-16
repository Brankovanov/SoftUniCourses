using Exercise_01_Person.Interface;

namespace Exercise_01_Person
{
    //Creates a Citizen object derived from the IPerson, IIdentifiable and IBirthable interfaces. It holds the citizens name, age, id and birthdate.
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

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

        public string Birthdate
        {
            get
            {
                return this.birthdate;
            }
            private set
            {
                this.birthdate = value;
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

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}