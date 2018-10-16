namespace Exercise_02_Ferrari
{
    //Derived class Ferrary.
    public class Ferrari : ICar
    {
        private string model = "488-Spider";
        private string driver;

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public string Driver
        {
            get
            {
                return this.driver;
            }
            private set
            {
                this.driver = value;
            }
        }

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Brake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brake()}/{this.Gas()}/{this.Driver}";
        }
    }
}