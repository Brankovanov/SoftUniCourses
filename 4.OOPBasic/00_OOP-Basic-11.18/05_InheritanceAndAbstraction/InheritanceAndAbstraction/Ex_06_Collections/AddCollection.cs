using System.Collections.Generic;

namespace Ex_06_Collections
{
    public class AddCollection : IAdd
    {
        private List<string> list;
        private string inputResult;

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

        public AddCollection()
        {
            this.List = new List<string>();
            this.InputResult = string.Empty;
        }



        public void Add(string element)
        {

            this.List.Add(element);
            this.InputResult+= (this.list.Count-1).ToString()+" ";

        }


    }
}
