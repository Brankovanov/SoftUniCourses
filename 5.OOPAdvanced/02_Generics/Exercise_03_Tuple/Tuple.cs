using System;
using System.Collections.Generic;

namespace Exercise_03_Tuple
{
    //Creates tuples and treeuples.
    public class Tuple<T>
    {
        private List<Tuple<T,T>> tupleList= new List<Tuple<T,T>>();
        private List<Tuple<T, T, T>> treeupleList = new List<Tuple<T, T, T>>();

        public List<Tuple<T,T,T>> TreeupleList
        {
            get
            {
                return this.treeupleList;
            }
            set
            {
                this.treeupleList = value;
            }
        }

        public List<Tuple<T,T>> TupleList
        {
            get
            {
                return this.tupleList;
            }
            set
            {
                this.tupleList = value;
            }
        }

        public void CreateTuple(T itemOne, T itemTwo)
        {
            var newTuple = Tuple.Create(itemOne, itemTwo);
            this.tupleList.Add(newTuple);
        }

        public void CreateTreeuple(T itemOne, T itemTwo, T itemTree)
        {
            var newTreeuple = Tuple.Create(itemOne, itemTwo, itemTree);
            this.treeupleList.Add(newTreeuple);
        }
    }
}