using System.Collections.Generic;

namespace Part_01_NeedForSpeed
{
    //A garage class.
    public class Garage
    {
        private List<Car> parkedCars = new List<Car>();

        public List<Car> ParkedCars
        {
            get
            {
                return this.parkedCars;
            }
            set
            {
                this.parkedCars = value;
            }
        }

        public Garage()
        {
            this.ParkedCars = parkedCars;
        }
    }
}