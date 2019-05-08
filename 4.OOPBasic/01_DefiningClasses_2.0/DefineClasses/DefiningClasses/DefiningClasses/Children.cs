using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Children
    {
        private Dictionary<string, string> child;

        public Dictionary<string, string> Child
        {
            get
            {
                return this.child;
            }
            set
            {
                this.child = value;
            }
        }

        public string Output()
        {
            var output = string.Empty;

            foreach (var child in this.Child)
            {
                output += child.Key + " " + child.Value;
            }

            output = Environment.NewLine + output;
            return output;
        }

        public Children()
        {
            this.child = new Dictionary<string, string>();
        }

    }
}
