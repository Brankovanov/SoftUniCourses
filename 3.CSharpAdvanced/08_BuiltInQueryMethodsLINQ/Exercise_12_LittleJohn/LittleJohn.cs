using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_12_LittleJohn
{
    public class LittleJohn
    {
        public static void Main(string[] args)
        {
            ReceiveArrows();
        }

        //Receives arrows from the console.
        public static void ReceiveArrows()
        {
            var arrowHay = new List<string>();
            var arrowPattern = new Regex("(>{1}-{5}>{1})|(>{2}-{5}>{1})|(>{3}-{5}>{2})");

            for (var index = 1; index <= 4; index++)
            {
                var arrow = Console.ReadLine();
                var hay = arrowPattern.Matches(arrow);

                foreach (Match arr in hay)
                {
                    arrowHay.Add(arr.ToString());
                }
            }

            CountTheArrows(arrowHay);
        }

        //Counts the arrows in the hay.
        public static void CountTheArrows(List<string> arrowHay)
        {
            var countLong = 0;
            var countMid = 0;
            var countSmall = 0;

            foreach (var arr in arrowHay.Where(a => a.Length == 10))
            {
                countLong++;
            }

            foreach (var arr in arrowHay.Where(a => a.Length == 8))
            {
                countMid++;
            }

            foreach (var arr in arrowHay.Where(a => a.Length == 7))
            {
                countSmall++;
            }

            Encrypt(countLong, countMid, countSmall);
        }

        //Encrypting the count of arrows.
        public static void Encrypt(int countLong, int countMid, int countSmall)
        {
            var num = int.Parse(string.Join("", countSmall.ToString(), countMid.ToString(), countLong.ToString()));
            var encrypted = Convert.ToString(num, 2);
            encrypted = encrypted + string.Join("", encrypted.Reverse());
            encrypted = Convert.ToInt32(encrypted, 2).ToString();

            Console.WriteLine(encrypted);
        }
    }
}