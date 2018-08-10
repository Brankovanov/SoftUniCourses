namespace Exercise_08_Google
{
    //Creates parents object that holds the parent's name and birthday.
    public class Parents
    {
        private string parentName;
        private string parentBirthday;

        public string ParentName
        {
            get
            {
                return this.parentName;
            }
            set
            {
                this.parentName = value;
            }
        }

        public string ParentBirthDay
        {
            get
            {
                return this.parentBirthday;
            }
            set
            {
                this.parentBirthday = value;
            }
        }

        public Parents(string parentName, string parentBirthday)
        {
            this.parentName = parentName;
            this.parentBirthday = parentBirthday;
        }
    }
}