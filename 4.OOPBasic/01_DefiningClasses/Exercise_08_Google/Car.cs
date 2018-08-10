namespace Exercise_08_Google
{
    //Creates a car object that holds information about the car model and speed.
    public class Car
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

        public Car(string carModel, int carSpeed)
        {
            this.carModel = carModel;
            this.carSpeed = carSpeed;
        }
    }
}