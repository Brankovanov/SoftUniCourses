﻿
using System;

namespace Lab_01_Person
{
    public class Child : Person
    {

        
        public override int Age
        {
            get
            {
                return base.Age;
            }
            protected set
            {
                if(value>0 && value<=15)
                {
                    base.Age = value;
                }
                else
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
            }
        }
        public Child(string name, int age)
            :base(name,age)
        {

        }
    }
}
