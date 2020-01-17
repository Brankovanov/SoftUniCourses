namespace Ex_07_Explicit
{
    public class Citizen : ICitizen, IResident
    {
        public string Name { get; set; }
        public int Age { get; set; }
        string IResident.Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                
            }
        }
        string IResident.Countryv { get; set ; }

        public string GetName()
        {
            return  this.Name;
        }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }

        public Citizen(string name)
        {
            this.Name = name;
            
        }
    }
}
