using System.Collections.Generic;

namespace Exercise_08_CollectionHierarchy
{
    //AddRemoveCollection class that is derived by IAddRemoveCollection interface.
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> addRemoveColl = new List<string>();

        public List<string> AddRemoveColl
        {
            get
            {
                return this.addRemoveColl;
            }
            set
            {
                this.addRemoveColl = value;
            }
        }

        public int Add(string item)
        {
            this.addRemoveColl.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            var output = this.addRemoveColl[this.addRemoveColl.Count - 1];
            this.addRemoveColl.RemoveAt(this.addRemoveColl.Count - 1);
            return output;
        }
    }
}