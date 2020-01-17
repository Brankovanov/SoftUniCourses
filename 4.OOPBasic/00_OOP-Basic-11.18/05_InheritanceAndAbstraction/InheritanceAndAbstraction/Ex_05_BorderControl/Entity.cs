namespace Ex_05_BorderControl
{
    public class Entity : IId, IBirthDate, IName, IAge, IFood,IBuy
    {
        private string id;
        private string birthDate;
        private string name;
        private int age;
        private int food;

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

        public virtual void BuyFood()
        {
            
        }
    }
}
