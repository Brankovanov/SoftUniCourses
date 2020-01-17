namespace Lab_05_AnimalFarm
{
    public class Kitten:Cat
    {
        private string gender;

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if(value=="Female")
                {
                    this.gender = value;
                }
                else
                {
                    this.gender = string.Empty;
                }
            }
        }

        public Kitten(string name,int age, string gender)
            :base(name, age,gender)
        {

        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
