
namespace Ex_05_BorderControl
{
    public class Citizen :Entity
    {
        
        public Citizen(string id, string name, int age,string birthDate)
            :base()
        {
            this.Food = 0;
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.BirthDate = birthDate;
        }

        public override void BuyFood()
        {
             this.Food += 10;
        }
        
    }
}
