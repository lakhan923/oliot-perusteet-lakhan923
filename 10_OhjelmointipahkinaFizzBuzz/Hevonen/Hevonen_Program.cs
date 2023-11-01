
using System.Security.Authentication.ExtendedProtection;
using System.Reflection;
using ElainLuokat;

namespace ElainLuokat
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kuinka monta eläintä luoda?");

            // Read the user's input as a string
            string userInput = Console.ReadLine();

            // Try to convert the input to an integer
            if (int.TryParse(userInput, out int numberOfRounds))
            {
                List<Elain> animals = new List<Elain>();

                for (int i = 1; i <= numberOfRounds; i++)
                {
                    Elain newAnimal = CreateAnimal(i);
                    animals.Add(newAnimal);
                }

                for (int i = 0; i < animals.Count; i++)
                {
                    PrintAnimalInfo(animals[i]);
                }
            }
        }

        static Elain CreateAnimal(int round)
        {
            switch (round % 4)
            {
                case 0:
                    return new Hevonen { Nimi = "Horse", Ika = round, Color = "Brown" };
                case 1:
                    return new Kissa { Nimi = "Cat", Ika = round, FavoriteToy = "Mouse" };
                case 2:
                    return new Koira { Nimi = "Dog", Ika = round, HumansBestFriend = true };
                case 3:
                    return new Papukaija { Nimi = "Parrot", Ika = round, FavoritePhrase = "Polly wants a cracker" };
                default:
                    return null;
            }
        }

        static void PrintAnimalInfo(Elain animal)
        {
            Console.WriteLine($"Name: {animal.Nimi}, Age: {animal.Ika}");

            if (animal is Koira dog)
            {
                Console.WriteLine($"Human's Best Friend: {dog.HumansBestFriend}");
            }
            else if (animal is Kissa cat)
            {
                Console.WriteLine($"Favorite Toy: {cat.FavoriteToy}");
            }
            else if (animal is Papukaija parrot)
            {
                Console.WriteLine($"Favorite Phrase: {parrot.FavoritePhrase}");
            }
            else if (animal is Hevonen horse)
            {
                Console.WriteLine($"Color: {horse.Color}");
            }

            Console.WriteLine();
        }
    }
}








