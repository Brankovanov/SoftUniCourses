namespace Exercise_08_PetClinic
{
    //Pet class that holds the pets name, age and kind.
    public class Pet
    {
        private string name;
        private int age;
        private string kind;

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

        public string Kind
        {
            get
            {
                return this.kind;
            }
            set
            {
                this.kind = value;
            }
        }

        public Pet(string name, int age, string kind)
        {
            this.Name = name;
            this.Age = age;
            this.Kind = kind;
        }
    }
}