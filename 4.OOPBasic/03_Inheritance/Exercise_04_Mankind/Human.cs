using System;

namespace Exercise_04_Mankind
{
    //Creates a parent class Human that holds the person's first name and last name.
    public class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.StartsWith(value[0].ToString().ToUpper()))
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

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.StartsWith(value[0].ToString().ToUpper()))
                {
                    if (value.Length > 2)
                    {
                        this.lastName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                    }
                }
                else
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}