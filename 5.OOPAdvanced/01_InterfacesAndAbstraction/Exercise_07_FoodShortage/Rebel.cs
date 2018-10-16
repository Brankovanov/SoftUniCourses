namespace Exercise_07_FoodShortage
{
    //Class Rebel class derived from the ICRebel interface.
    public class Rebel : IRebel
    {
        private string group;
        private string name;
        private int age;
        private int food = 0;

        public string Group
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
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

        public Rebel(string group, string name, int age)
        {
            this.Group = group;
            this.Name = name;
            this.Age = age;
        }

        public void BuyFood()
        {
            this.food += 5;
        }
    }
}