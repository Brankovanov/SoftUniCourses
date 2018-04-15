using System;

namespace _16_CleverLili
{
    public class cleverLili
    {
        public static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var pricePerToy = double.Parse(Console.ReadLine());
            var moneyFromToys = 0.0;
            var moneyPerBirthday = 0;

            for (var birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    moneyPerBirthday = moneyPerBirthday + ((birthday * 10) / 2) - 1;
                }
                else
                {
                    moneyFromToys = moneyFromToys + pricePerToy;
                }
            }

            if (price <= moneyPerBirthday + moneyFromToys)
            {
                Console.WriteLine("Yes! " + "{0:F2}", (moneyPerBirthday + moneyFromToys) - price);
            }
            else
            {
                Console.WriteLine("No! " + "{0:F2}", price - (moneyPerBirthday + moneyFromToys));
            }
        }
    }
}
