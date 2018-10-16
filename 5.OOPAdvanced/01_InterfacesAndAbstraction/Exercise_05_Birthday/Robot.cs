namespace Exercise_05_Birthday
{
    //Derived class from the ICreated interface. Holds the robot's model and id.
    public class Robot : ICreated
    {
        private string model;
        private string id;

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}