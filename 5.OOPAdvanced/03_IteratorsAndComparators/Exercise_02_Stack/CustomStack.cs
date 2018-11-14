using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_Stack
{
    //Creates a custom stack collection with custom logic.
    public class CustomStack : IEnumerable
    {
        private List<string> customizedStack = new List<string>();

        public void Pop()
        {
            if (this.customizedStack.Count > 0)
            {
                this.customizedStack.Remove(GetEnumerator().Current.ToString());
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }

        public void Push(string[] item)
        {
            this.customizedStack.AddRange(item);
        }

        public string Iterator()
        {
            this.customizedStack.Reverse();
            return string.Join(Environment.NewLine, this.customizedStack);
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomEnumerator(this.customizedStack);
        }
    }

    public class CustomEnumerator : IEnumerator
    {
        private List<string> localSet;

        public CustomEnumerator(List<string> list)
        {
            this.localSet = list;
        }

        public object Current
        {
            get
            {
                return this.localSet.Last();
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}