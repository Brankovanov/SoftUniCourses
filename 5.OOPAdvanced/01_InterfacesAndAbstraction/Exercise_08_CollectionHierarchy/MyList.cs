using System.Collections.Generic;

namespace Exercise_08_CollectionHierarchy
{
    //MyList class that is derived by IMyList interface.
    public class MyList : IMyList
    {
        private int used = 0;
        private List<string> myL = new List<string>();

        public int Used
        {
            get
            {
                return this.used;
            }
            set
            {
                this.used = value;
            }
        }

        public List<string> MyL
        {
            get
            {
                return this.myL;
            }
            set
            {
                this.myL = value;
            }
        }

        public int Add(string item)
        {
            this.myL.Insert(0, item);
            this.used++;
            return 0;
        }

        public string Remove()
        {
            var output = this.myL[0];
            this.myL.RemoveAt(0);
            this.used--;
            return output;
        }
    }
}