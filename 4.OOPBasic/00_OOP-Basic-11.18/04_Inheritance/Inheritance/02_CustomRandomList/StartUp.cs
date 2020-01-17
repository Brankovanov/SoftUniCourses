using System;

namespace _02_CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            var randomList = new RandomList();

            randomList.Add("aa");
            randomList.Add("ab");
            randomList.Add("ac");
            randomList.Add("ad");
            randomList.Add("ae");
            randomList.Add("af");
            randomList.Add("ag");

            while(randomList.Count>0)
            {
                Console.WriteLine(randomList.GetRandomElement());
            }
        }
    }
}
