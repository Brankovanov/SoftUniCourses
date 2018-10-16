namespace Exercise_04_BorderControl_
{
    //Derived class from the IEntity interface. Holds the citizen's name, id and age.
    public class Citizen : IEntity
    {
        private string designation;
        private string id;
        private int age;

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

        public string Designation
        {
            get
            {
                return this.designation;
            }
            private set
            {
                this.designation = value;
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

        public Citizen(string designation, string id, int age)
        {
            this.Designation = designation;
            this.Id = id;
            this.Age = age;
        }
    }
}