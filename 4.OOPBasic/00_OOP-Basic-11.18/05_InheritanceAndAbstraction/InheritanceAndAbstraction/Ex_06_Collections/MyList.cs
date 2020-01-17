using System.Collections.Generic;

namespace Ex_06_Collections
{
    public class MyList : IAdd, IRemove, IUsed
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

        public MyList()
        {
            this.List = new List<string>();
        }

        public void Add(string element)
        {

            this.List.Insert(0, element);
            this.InputResult += "0 ";
        }

        public void Remove()
        {
            this.OutputResult += this.List[0] + " ";
            this.List.Remove(this.List[0]);
        }

        public int Count()
        {
            return this.List.Count;
        }
    }
}
