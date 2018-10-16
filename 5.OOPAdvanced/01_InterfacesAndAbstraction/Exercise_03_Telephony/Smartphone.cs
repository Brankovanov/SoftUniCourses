using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_03_Telephony
{
    //Derived class smartphone it holds the phone's model and a list of numbers and sites to dial and browse. Also the dialing and browsing functionality.
    public class Smartphone : IModel, IFunctionality
    {
        private string model = "Smartphone";
        private List<string> numbers = new List<string>();
        private List<string> sites = new List<string>();

        public List<string> Numbers
        {
            get
            {
                return this.numbers;
            }
            private set
            {
                this.numbers = value;
            }
        }

        public List<string> Sites
        {
            get
            {
                return this.sites;
            }
            private set
            {
                this.sites = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public Smartphone(List<string> phones, List<string> sites)
        {
            this.Numbers.AddRange(phones);
            this.Sites.AddRange(sites);
        }

        public string Calling()
        {
            var callHistory = string.Empty;

            foreach (var number in this.Numbers)
            {
                if (!number.Any(c => char.IsDigit(c)))
                {
                    callHistory += $"Invalid number!{Environment.NewLine}";
                }
                else if (number.Any(c => char.IsDigit(c)))
                {
                    callHistory += $"Calling... {number}{Environment.NewLine}";
                }
            }

            return callHistory;
        }

        public string Browsing()
        {
            var browseHistory = string.Empty;

            foreach (var site in this.Sites)
            {
                if (!site.Any(c => char.IsDigit(c)))
                {
                    browseHistory += $"Browsing: {site}!{Environment.NewLine}";
                }
                else if (site.Any(c => char.IsDigit(c)))
                {
                    browseHistory += $"Invalid URL!{Environment.NewLine}";
                }
            }

            return browseHistory;
        }
    }
}