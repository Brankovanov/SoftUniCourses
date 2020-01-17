using System;

namespace _04_ManKind
{
    public class Human
    {
        private string firstName;
        private string secondName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value[0].ToString() == value[0].ToString().ToUpper())
                {
                    if (value.Length > 3)
                    {
                        this.firstName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                    }
                }
                else
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
            }
        }

        public string SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                if (value[0].ToString() == value[0].ToString().ToUpper())
                {
                    if (value.Length > 2)
                    {
                        this.secondName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName ");
                    }
                }
                else
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
            }
        }

        public Human(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }


        public override string ToString()
        {
            return $"First Name: {this.FirstName}" + Environment.NewLine + $"Second Name: {this.SecondName}" +Environment.NewLine;
        }
    }
}
