using System.Reflection;

namespace ElainLuokat
{
    class Program
    {
        public static void Main(string[] args)
        {
            //  for loop for dog and cat object
            for (int i = 0; i < 1; i++)
            {
                // Value age for the dog between 1-15
                Koira koiran_obj = new Koira();
                Random rnd = new Random();
                int random_koiran_ika = rnd.Next(1, 16);
                koiran_obj.SetIka(random_koiran_ika);

                // Value age for the cat between 1-10
                Kissa kissan_obj = new Kissa();
                Random rnd2 = new Random();
                int random_kissan_ika = rnd2.Next(1, 11);
                kissan_obj.SetIka(random_kissan_ika);


                // Setting the ages of dog and cat on the object.
                int koiran_ika = koiran_obj.PalautaIka();
                int kissan_ika = kissan_obj.PalautaIka();

                Console.WriteLine("Koira on: " + koiran_ika + " " + "vuotta" + ", " + "Kissa on: " + kissan_ika + " " + "vuota");
                
                //use of if statement to compare the ages of dog and cat objects
                if(koiran_ika > kissan_ika)
                {
                    System.Console.WriteLine("Koira on vanha.");
                }
                else if(koiran_ika == kissan_ika)
                {
                    System.Console.WriteLine("Molemmat ovat vanhempia");
                }
                else
                {
                    System.Console.WriteLine("Kissa on vanha.");
                }

                // new Dog object using the new constructor
                Koira bark = new Koira();
                bark.haukku = "Koira sanoo \"woof woof\"";
                System.Console.WriteLine(bark.haukku);

                Kissa spin = new Kissa();
                spin.kehrays = "Kissa kehrää \"hrrr hrrr...\"";
                System.Console.WriteLine(spin.kehrays);

                

                         
            }

        }
    }
}
