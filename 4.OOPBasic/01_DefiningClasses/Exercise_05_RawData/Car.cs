using System.Collections.Generic;

namespace Exercise_05_RawData
{
    //Creates the car object that holds the information about the cars's model, engine, cargo and tyre.
    public class Car
    {
        private string model;
        private Engine carEngine;
        private Cargo carCargo;
        private List<Tyre> carTyre;

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

        public Engine CarEngine
        {
            get
            {
                return this.carEngine;
            }
            set
            {
                this.carEngine = value;
            }
        }

        public Cargo CarCargo
        {
            get
            {
                return this.carCargo;
            }
            set
            {
                this.carCargo = value;
            }
        }

        public List<Tyre> CarTyre
        {
            get
            {
                return this.carTyre;
            }
            set
            {
                this.carTyre = value;
            }
        }

        public Car(string model, int engineSpeed, int enginePower,
                   int cargoWeight, string cargoType,
                   double tyreOnePressure, int tyreOneAge,
                   double tyreTwoPressure, int tyreTwoAge,
                   double tyreThreePressure, int tyreThreeAge,
                   double tyreFourPressure, int tyreFourAge)
        {
            this.model = model;
            this.carEngine = new Engine(engineSpeed, enginePower);
            this.carCargo = new Cargo(cargoWeight, cargoType);
            var tyreList = new List<Tyre>();
            tyreList.Add(new Tyre(tyreOneAge, tyreOnePressure));
            tyreList.Add(new Tyre(tyreTwoAge, tyreTwoPressure));
            tyreList.Add(new Tyre(tyreThreeAge, tyreThreePressure));
            tyreList.Add(new Tyre(tyreFourAge, tyreFourPressure));
            this.carTyre = tyreList;
        }
    }
}