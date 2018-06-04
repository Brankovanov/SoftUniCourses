using System;

namespace Exercise_09_HarlemShake
{
    public class harlemShake
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Приема текст от конзолата.
        static void ReceiveInput()
        {
            var randomString = Console.ReadLine();
            var randomPattern = Console.ReadLine();

            ShakeIt(randomString, randomPattern);
        }

        //Сортира текста и премахва крайните прояви на образеца.
        static void ShakeIt(string randomString, string randomPattern)
        {
            var startingIndex = 0;
            var endingIndex = 0;

            while (randomPattern.Length > 0 && randomString.Length > 0)
            {
                startingIndex = randomString.IndexOf(randomPattern);
                endingIndex = randomString.LastIndexOf(randomPattern);

                if(startingIndex>=0 && endingIndex>=0 && startingIndex!=endingIndex)
                {
                    SuccessfullShake();
                    randomString = randomString.Remove(startingIndex, randomPattern.Length);
                    randomString = randomString.Remove(endingIndex-randomPattern.Length, randomPattern.Length);
                    randomPattern = randomPattern.Remove(randomPattern.Length / 2, 1);
                    
                }
                else
                {
                    UnsuccessfullShake(randomString);
                    break;
                }
            }

            if(randomPattern.Length<1 || randomString.Length<1)
            {
                UnsuccessfullShake(randomString);
            }
        }

        //Отпечатва на конзолата изход при успешна операция.
        static void SuccessfullShake()
        {
            Console.WriteLine("Shaked it.");
        }

        //Отпечатва изход на конзолата при неуспешна операция
        static void UnsuccessfullShake(string randomString)
        {
            Console.WriteLine("No shake.");
            Console.WriteLine(randomString);
        }
    }
}
