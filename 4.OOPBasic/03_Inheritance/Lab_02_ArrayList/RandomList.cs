using System;
using System.Collections;

namespace Lab_02_ArrayList
{
    //Creates a custom arraylist that can also return a random entry from the list and deletes it after that.
    public class RandomList : ArrayList
    {
        private Random random;
        private ArrayList rList;

        public ArrayList RList
        {
            get
            {
                return this.rList;
            }
            private set
            {
                this.rList = value;
            }
        }

        public RandomList()
        {
            this.random = new Random();
            this.rList = new ArrayList();
        }

        public string RandomString()
        {
            var randElement = random.Next(0, rList.Count);
            var output = rList[randElement].ToString();
            rList.RemoveAt(randElement);
            return output;
        }
    }
}