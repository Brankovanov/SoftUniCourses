using System.Collections.Generic;

namespace Exercise_08_CollectionHierarchy
{
    //AddCollection class that is derived by IAddCollection interface.
    public class AddCollection : IAddCollection
    {
        private List<string> addColl = new List<string>();

        public List<string> AddColl
        {
            get
            {
                return this.addColl;
            }
            set
            {
                this.addColl = value;
            }
        }

        public int Add(string item)
        {
            this.addColl.Add(item);
            return this.addColl.LastIndexOf(item);
        }
    }
}