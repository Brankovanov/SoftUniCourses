using System;

namespace Ex_02_Car
{
    public class Ferrary:IFunctions
    {
        private string driver;
        private string model;

        public string Driver
        {
            get
            {
                return this.driver;
            }
            set
            {
                this.driver = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public Ferrary(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public void Gas()
        {
            Console.Write("Zadu6avam sA!");
        }

        public void Brakes()
        {
            Console.Write("Brakes!");
        }
    }
}
