namespace Part_2_Avatar
{
    //Base class monument. Holds the monument's name.
    public abstract class Monument
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Monument(string name)
        {
            this.Name = name;
        }
    }
}