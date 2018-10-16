namespace Exercise_04_BorderControl_
{
    //Derived class from the IEntity interface. Holds the robot's model and id.
    public class Robot : IEntity
    {
        private string designation;
        private string id;

        public string Designation
        {
            get
            {
                return this.designation;
            }
            private set
            {
                this.designation = value;
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

        public Robot(string designation, string id)
        {
            this.Designation = designation;
            this.Id = id;
        }
    }
}