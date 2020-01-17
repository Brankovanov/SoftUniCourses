
using System.Collections.Generic;

namespace Ex_06_Collections
{
    public class AddRemoveCollection : IAdd, IRemove
    {
        private List<string> list;
        private string inputResult;
        private string outputResult;

        public List<string> List
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

        public string InputResult
        {
            get
            {
                return this.inputResult;
            }
            set
            {
                this.inputResult = value;
            }
        }
        public string OutputResult
        {
            get
            {
                return this.outputResult;
            }
            set
            {
                this.outputResult = value;
            }
        }

        public AddRemoveCollection()
        {
            this.List = new List<string>();
            this.InputResult = string.Empty;
            this.OutputResult = string.Empty;
        }

        public void Add(string element)
        {

            this.List.Insert(0, element);
           this.InputResult+= "0 ";
        }

        public void Remove()
        {
            this.OutputResult += this.List[this.List.Count - 1] + " ";
            this.List.RemoveAt(this.List.Count-1);
        }
    }
}
