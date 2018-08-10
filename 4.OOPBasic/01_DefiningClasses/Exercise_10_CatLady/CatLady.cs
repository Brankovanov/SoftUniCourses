using System;
using System.Collections.Generic;

namespace Exercise_10_CatLady
{
    public class CatLady
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receives cat information from the console.
        public static void ReceiveInput()
        {
            var catArchive = new List<Cat>();
            var catSpecification = Console.ReadLine();

            while (catSpecification != "End")
            {
                ProcessCats(catSpecification, catArchive);
                catSpecification = Console.ReadLine();
            }

            var cat = Console.ReadLine();
            PrintCat(cat, catArchive);
        }

        //Pricesses the cat information.
        public static void ProcessCats(string catSpecification, List<Cat> catArchive)
        {
            var temp = catSpecification.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var breed = temp[0];
            var name = temp[1];
            var specification = double.Parse(temp[2]);

            switch (breed)
            {
                case "Siamese":

                    var newSiamese = new Siamese((int)specification, name, breed);
                    catArchive.Add(newSiamese);
                    break;

                case "Cymric":

                    var newCymric = new Cymric(specification, name, breed);
                    catArchive.Add(newCymric);
                    break;

                case "StreetExtraordinaire":

                    var newStreetExtraordinaire = new StreetExtraordinaire((int)specification, name, breed);
                    catArchive.Add(newStreetExtraordinaire);
                    break;
            }
        }

        //Prints the specifications of the cat we seek.
        public static void PrintCat(string cat, List<Cat> catArchive)
        {
            if (catArchive.Find(c => c.Name == cat).Breed == "Cymric")
            {
                Console.WriteLine(string.Join(" ", catArchive.Find(c => c.Name == cat).Breed, catArchive.Find(c => c.Name == cat).Name,
                    string.Format("{0:0.00}", ((Cymric)catArchive.Find(c => c.Name == cat)).FurLenght)));
            }
            else if (catArchive.Find(c => c.Name == cat).Breed == "Siamese")
            {
                Console.WriteLine(string.Join(" ", catArchive.Find(c => c.Name == cat).Breed, catArchive.Find(c => c.Name == cat).Name,
                   ((Siamese)catArchive.Find(c => c.Name == cat)).EarSize));
            }
            else if (catArchive.Find(c => c.Name == cat).Breed == "StreetExtraordinaire")
            {
                Console.WriteLine(string.Join(" ", catArchive.Find(c => c.Name == cat).Breed, catArchive.Find(c => c.Name == cat).Name,
                     ((StreetExtraordinaire)catArchive.Find(c => c.Name == cat)).DecibelsOfMeows));

            }
        }
    }
}