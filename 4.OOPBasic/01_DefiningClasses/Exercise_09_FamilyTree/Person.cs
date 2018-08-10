using System.Collections.Generic;

namespace Exercise_09_FamilyTree
{
    //Creates person objekt that holds persons' name, birthday, parents and children.
    public class Person
    {
        private string designation;
        private string birthDay;
        private List<Person> parents;
        private List<Person> children;

        public string Designation
        {
            get
            {
                return this.designation;
            }
            set
            {
                this.designation = value;
            }
        }

        public string BirthDay
        {
            get
            {
                return this.birthDay;
            }
            set
            {
                this.birthDay = value;
            }
        }

        public List<Person> Parents
        {
            get
            {
                return this.parents;
            }
            set
            {
                this.parents = value;
            }
        }

        public List<Person> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                this.children = value;
            }
        }

        public Person(string designation, List<Person> parents, List<Person> children, string birthDay)
        {
            this.designation = designation;
            this.parents = parents;
            this.children = children;
            this.birthDay = birthDay;
        }
    }
}