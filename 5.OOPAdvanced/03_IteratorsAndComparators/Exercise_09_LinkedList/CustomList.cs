using System.Collections.Generic;

namespace Exercise_09_LinkedList
{
    //Holds the custom list logic.
    public class CustomList
    {
        private List<int> customL;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        public List<int> CustomL
        {
            get
            {
                return this.customL;
            }
            set
            {
                this.customL = value;
            }
        }

        public CustomList()
        {
            this.CustomL = new List<int>();
        }

        public void Add(int element)
        {
            this.CustomL.Add(element);
            this.Count = this.CustomL.Count;
        }

        public bool Remove(int element)
        {
            if (this.CustomL.Contains(element))
            {
                this.CustomL.Remove(element);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this.CustomL); ;
        }
    }
}