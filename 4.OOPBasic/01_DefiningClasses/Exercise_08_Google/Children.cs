namespace Exercise_08_Google
{
    //Creates a child object that holds information about the child's name and birthday.
    public class Children
    {
        private string childName;
        private string childBirthday;

        public string ChildName
        {
            get
            {
                return this.childName;
            }
            set
            {
                this.childName = value;
            }
        }

        public string ChildBirthday
        {
            get
            {
                return this.childBirthday;
            }
            set
            {
                this.childBirthday = value;
            }
        }

        public Children(string childName, string childBirthday)
        {
            this.childName = childName;
            this.childBirthday = childBirthday;
        }
    }
}