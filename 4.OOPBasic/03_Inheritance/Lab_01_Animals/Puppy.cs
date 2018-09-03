using System;

namespace Lab_01_Animals
{
    //Creates a puppy object. Derived from the dog object.
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
}
