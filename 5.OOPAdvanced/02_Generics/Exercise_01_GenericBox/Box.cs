using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_01_GenericBox
{
    //Generic class box that can be initialized with any type.
    public class Box<T> where T : IComparable
    {
        private List<T> collection = new List<T>();
        private T comparer;

        public T Comparer
        {
            get
            {
                return this.comparer;
            }
            set
            {
                this.comparer = value;
            }
        }

        public List<T> Collection
        {
            get
            {
                return this.collection;
            }
            set
            {
                this.collection = value;
            }
        }

        public void Add(T value)
        {
            this.collection.Add(value);
        }

        public int CompareTo()
        {
            var counter = 0;

            foreach (var entity in this.collection)
            {
                if(entity.CompareTo(this.comparer)>0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var elementOne = this.collection[firstIndex];
            var elementTwo = this.collection[secondIndex];

            this.collection[firstIndex] = elementTwo;
            this.collection[secondIndex] = elementOne;
        }

        public override string ToString()
        {
            var output = string.Empty;

            foreach (var item in this.collection.Distinct())
            {
                output += $"{item.GetType()}: {item}"+Environment.NewLine;
            }

            return output;
        }
    }
} 