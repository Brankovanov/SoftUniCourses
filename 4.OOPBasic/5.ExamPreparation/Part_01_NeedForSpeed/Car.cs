namespace Part_01_NeedForSpeed
{
    //Parent abstract class car that holds the basic car characteristics.
    public abstract class Car
    {
        private string brand;
        private string model;
        private int yearOfProduction;
        private int horsePower;
        private int acceleration;
        private int suspension;
        private int durability;
        private int id;
        private string type;

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
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

        public int YearOfProduction
        {
            get
            {
                return this.yearOfProduction;
            }
            set
            {
                this.yearOfProduction = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }

        public int Acceleration
        {
            get
            {
                return this.acceleration;
            }
            set
            {
                this.acceleration = value;
            }
        }

        public int Suspension
        {
            get
            {
                return this.suspension;
            }
            set
            {
                this.suspension = value;
            }
        }

        public int Durability
        {
            get
            {
                return this.durability;
            }
            set
            {
                this.durability = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int id, string type)
        {
            this.Brand = brand;
            this.Model = model;
            this.YearOfProduction = yearOfProduction;
            this.HorsePower = horsePower;
            this.Acceleration = acceleration;
            this.Suspension = suspension;
            this.Durability = durability;
            this.Id = id;
            this.Type = type;
        }

        public virtual void Tune(int index, string addons)
        {
            this.HorsePower = this.HorsePower + index;
            this.Suspension = this.Suspension + (index / 2);
        }

        public override string ToString()
        {
            return null;
        }
    }
}