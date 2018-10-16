namespace Exercise_07_FoodShortage
{
    //Class Citizen class derived from the ICitizen interface.
    public class Citizen : ICitizen
    {
        private string birthdate;
        private string name;
        private int age;
        private string id;
        private int food = 0;

        public string Birthdate
        {
            get
            {
                return this.birthdate;
            }
            set
            {
                this.birthdate = value;
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

        public int Food
        {
            get
            {
                return this.food;
            }
            set
            {
                this.food = value;
            }
        }

        public Citizen(string birthday, string name, int age, string id)
        {
            this.Birthdate = birthday;
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}