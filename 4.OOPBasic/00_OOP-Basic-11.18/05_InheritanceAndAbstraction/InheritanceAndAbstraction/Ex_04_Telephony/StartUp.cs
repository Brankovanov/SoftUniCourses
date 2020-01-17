using System;

namespace Ex_04_Telephony
{
    public class StartUp
    {
        static void Main()
        {
            var phones = Console.ReadLine();
            var adresses = Console.ReadLine();

            var newSmartPhone = new Smartphone();

            newSmartPhone.Calling(phones);
            newSmartPhone.Browsing(adresses);
        }
    }
}
