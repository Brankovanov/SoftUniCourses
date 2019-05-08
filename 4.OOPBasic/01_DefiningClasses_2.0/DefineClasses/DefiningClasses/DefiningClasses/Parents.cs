using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Parents
    {
        private Dictionary<string, string> parent;

        public Dictionary<string, string> Parent
        {
            get
            {
                return this.parent;
            }
            set
            {
                this.parent = value;
            }
        }

        public string Output()
        {
            var output = string.Empty;

            foreach (var parent in this.Parent)
            {
                output += parent.Key + " " + parent.Value + Environment.NewLine;
            }

            output = Environment.NewLine + output;
            return output;
        }

        public Parents()
        {
            this.Parent = new Dictionary<string, string>();
        }
    }
}