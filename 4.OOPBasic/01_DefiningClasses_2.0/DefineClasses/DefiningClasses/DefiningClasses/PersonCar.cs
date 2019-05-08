using System;

namespace DefiningClasses
{
    public class PersonCar
    {
        private string carModel;
        private int carSpeed;

        public string CarModel
        {
            get
            {
                return this.carModel;
            }
            set
            {
                this.carModel = value;
            }
        }

        public int CarSpeed
        {
            get
            {
                return this.carSpeed;
            }
            set
            {
                this.carSpeed = value;
            }
        }

        public string Output()
        {
            var output = string.Empty;
            output = Environment.NewLine+ this.CarModel + " " + this.CarSpeed + Environment.NewLine;
            return output;
        }
    }
}
