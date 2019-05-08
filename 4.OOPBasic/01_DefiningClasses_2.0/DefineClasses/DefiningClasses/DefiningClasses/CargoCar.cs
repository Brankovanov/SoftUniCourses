using System.Collections.Generic;

namespace DefiningClasses
{
    public class CargoCar
    {
        private string model;
        private Tire tires;
        private Cargos cargo;
        private Engines engine;

        public Engines Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public Cargos Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        public Tire Tires
        {
            get
            {
                return this.tires;
            }
            set
            {
                this.tires = value;
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

        public CargoCar(string model, int power, int speed, int weight, string type,
            int ageOne, double pressureOne, int ageTwo, double pressureTwo,
            int ageTree, double pressureTree, int ageFour, double pressureFour)
        {
            this.Model = model;
            this.Engine = new Engines(power, speed);
            this.Cargo = new Cargos(weight, type);
            this.Tires = new Tire(ageOne, pressureOne, ageTwo, pressureTwo,
                ageTree, pressureTree, ageFour, pressureFour);

        }
    }
}

