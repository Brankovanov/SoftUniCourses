using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_01_ListIterator
{
    //Creates a custom list with a custom iterator.
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> elements = new List<T>();
        private int index = 0;

        public List<T> Elements
        {
            get
            {
                return this.elements;
            }
            set
            {
                this.elements = value;
            }
        }

        public bool HasNext()
        {
            if (this.index < this.elements.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PrintAll()
        {
            return string.Join(" ", this.elements);
        }

        public bool MoveNext()
        {
            if (this.index < this.elements.Count - 1)
            {
                this.index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Print()
        {
            return this.Elements[this.index].ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}