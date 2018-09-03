using System.Collections.Generic;

namespace Lab_02_ArrayList
{
    //Creates a StackOfStrings that can push, pop, peek and check if the stack is empty.
    public class StackOfStrings
    {
        private List<string> data;

        public List<string> Data
        {
            get
            {
                return this.data;
            }
            private set
            {
                this.data = value;
            }
        }

        public void Push(string item)
        {
            this.data.Add(item);
        }

        public string Pop()
        {
            var output = data[0];
            data.RemoveAt(0);
            return output;
        }

        public string Peek()
        {
            var output = data[0];
            return output;
        }

        public bool IsEmpty()
        {
            if (data.Count == 0)
            {
                return true;
            }
            else if (data.Count > 0)
            {
                return false;
            }

            return false;
        }
    }
}