using System.Collections.Generic;

namespace DefiningClasses
{
    public class Tire
    {
        private int tireOneAge;
        private double tireOnePressure;
        private int tireTwoAge;
        private double tireTwoPressure;
        private int tireTreeAge;
        private double tireTreePressure;
        private int tireFourAge;
        private double tireFourPressure;

        public int TireOneAge
        {
            get
            {
                return this.tireOneAge;
            }
            set
            {
                this.tireOneAge = value;
            }
        }
        public double TireOnePressure
        {
            get
            {
                return this.tireOnePressure;
            }
            set
            {
                this.tireOnePressure = value;
            }
        }
        public int TireTwoAge
        {
            get
            {
                return this.tireTwoAge;
            }
            set
            {
                this.tireTwoAge = value;
            }
        }
        public double TireTwoPressure
        {
            get
            {
                return this.tireTwoPressure;
            }
            set
            {
                this.tireTwoPressure = value;
            }
        }
        public int TireTreeAge
        {
            get
            {
                return this.tireTreeAge;
            }
            set
            {
                this.tireTreeAge = value;
            }
        }
        public double TireTreePressure
        {
            get
            {
                return this.tireTreePressure;
            }
            set
            {
                this.tireTreePressure = value;
            }
        }
        public int TireFourAge
        {
            get
            {
                return this.tireFourAge;
            }
            set
            {
                this.tireFourAge = value;
            }
        }
        public double TireFourPressure
        {
            get
            {
                return this.tireFourPressure;
            }
            set
            {
                this.tireFourPressure = value;
            }
        }

        public Tire(int ageOne, double pressureOne, int ageTwo, double pressureTwo,
            int ageTree, double pressureTree, int ageFour, double pressureFour)
        {
            this.TireOneAge = ageOne;
            this.TireOnePressure = pressureOne;
            this.TireTwoAge = ageTwo;
            this.TireTwoPressure = pressureTwo;
            this.TireTreeAge = ageTree;
            this.TireTreePressure = pressureTree;
            this.TireFourAge = ageFour;
            this.TireFourPressure = pressureFour;
        }
    }
}
