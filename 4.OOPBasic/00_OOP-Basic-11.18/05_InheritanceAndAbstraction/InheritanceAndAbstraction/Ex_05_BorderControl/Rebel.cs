namespace Ex_05_BorderControl
{
    public class Rebel:Entity,IBuy
    {
        private string group;
        public string Group
        {
            get
            {
                return this.group = Group;
            }
            set
            {
                this.group = value;
            }
        }



    public Rebel(string name, string group,int age)
            :base()
        {
            this.Food = 0;
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public override void BuyFood()
        {
             this.Food += 10;
        }

    }
}
