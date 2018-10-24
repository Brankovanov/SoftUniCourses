using System.Collections.Generic;
using System.Linq;

namespace Lab_01_Box
{
    //Generic class box that holds a generic list and its count.
    public class Box<T>
    {
        private List<T> collectionHolder = new List<T>();
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public List<T> CollectionHolder
        {
            get
            {
                return this.collectionHolder;
            }
            set
            {
                this.collectionHolder = value;
            }
        }

        public void Add(T element)
        {
            this.collectionHolder.Add(element);
            this.count++;
        }

        public T Remove()
        {
            var output = this.collectionHolder.Last();
            this.collectionHolder.Remove(output);
            this.count--;
            return output;
        }
    }
}