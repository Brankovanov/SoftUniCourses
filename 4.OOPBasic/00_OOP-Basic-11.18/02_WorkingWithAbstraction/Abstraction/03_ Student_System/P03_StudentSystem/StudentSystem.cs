using System.Collections.Generic;

namespace P03_StudentSystem
{
    public class StudentSystem
    {
        private Dictionary<string, Student> repo;

        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repo
        {
            get { return repo; }
            private set { repo = value; }
        }
    }
}
