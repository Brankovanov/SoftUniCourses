using System;
using System.Linq;

namespace Exercise_03_Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            var phones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var sites = Console.ReadLine().Split(new char[] { ' ' }).ToList();

            IFunctionality smartPhone = new Smartphone(phones, sites);
            Console.Write(smartPhone.Calling());
            Console.Write(smartPhone.Browsing());
        }
    }
}