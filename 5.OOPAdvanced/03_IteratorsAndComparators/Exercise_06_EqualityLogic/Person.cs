namespace Exercise_06_EqualityLogic
{
    //Person class that holds person's name and age.
    public class Person
    {
        private string name;
        private int age;

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

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}