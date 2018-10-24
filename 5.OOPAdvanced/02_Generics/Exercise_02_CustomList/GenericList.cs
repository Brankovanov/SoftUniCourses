using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_CustomList
{
    //Creates a generic list that can hold elements of different types and compares them.
    public class GenericList<T> where T : IComparable
    {
        private List<T> list = new List<T>();

        public List<T> List
        {
            get
            {
                return this.list;
            }
            set
            {
                this.list = value;
            }
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove(int index)
        {
            var removed = this.list[index];
            this.list.RemoveAt(index);
            return removed;
        }

        public bool Contains(T element)
        {
            return this.list.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstElement = this.list[firstIndex];
            var secondElement = this.list[secondIndex];

            this.list[firstIndex] = secondElement;
            this.list[secondIndex] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            var counter = 0;

            foreach(var entity in this.list)
            {
                if(entity.CompareTo(element)>0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public T Max()
        {
            return this.list.Max();
        }

        public T Min()
        {
            return this.list.Min();
        }
    }
}