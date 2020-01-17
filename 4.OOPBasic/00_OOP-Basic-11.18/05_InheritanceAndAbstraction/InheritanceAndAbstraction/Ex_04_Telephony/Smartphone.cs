using System;
using System.Linq;

namespace Ex_04_Telephony
{
    public class Smartphone : IBrowsing, ICalling
    {
        public void Calling(string numbers)
        {
            var phonebook = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var phone in phonebook)
            {
                if (phone.Any(c => char.IsLetter(c)))
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    Console.WriteLine($"Calling... {phone}");
                }

            }
        }

        public void Browsing(string adresses)
        {
            var adressBook = adresses.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var adress in adressBook)
            {
                if (adress.Any(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                     Console.WriteLine($"Browsing... {adress}");
                }
               
            }
        }
    }
}
