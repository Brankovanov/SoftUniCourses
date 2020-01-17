using System.Collections.Generic;

namespace Lab_05_AnimalFarm
{
    public class Farm
    {
        private List<Animal> animals;

        public List<Animal> Animals
        {
            get
            {
                return this.animals;
            }
            set
            {
                this.animals = value;
            }
        }

        public Farm()
        {
            this.Animals = new List<Animal>();
        }
    }
}
