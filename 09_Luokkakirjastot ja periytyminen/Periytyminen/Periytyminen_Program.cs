using System.Threading.Tasks.Dataflow;
namespace ElainLuokat
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creating a new Cat object
            Kissa asentanKissan = new Kissa();
            // setting a name for cat object
            asentanKissan.AsetaKissanNimi("Pettu");
            // setting an age for cat obhect
            asentanKissan.AsetaKissanIka(10);
            // setting whether carnivore or not (true or false)
            asentanKissan.AsetaOnLihanSyoja(true);
            // Printing the cat's name and age and whether it is a carnivore using the ReturnName(), ReturnAge() and ReturnOnCarnivores() functions
            System.Console.WriteLine("Elain nimi on" + " " + asentanKissan.PalautaNimi() + " " + "ja" + " " + "ikä on" + " " + asentanKissan.PalautaIka() + " " + "ja Lihansyoja" + " " + "on" + " " + asentanKissan.PalautaOnLihanSyoja());
            // telling the cat to purr
            asentanKissan.Kehraa();

            // Creating a new dog object
            Koira AsentanKoiran = new Koira();
            AsentanKoiran.AsetaKissanNimi("Muurri");
            AsentanKoiran.AsetaKissanIka(12);
            AsentanKoiran.AsetaOnLihanSyoja(false);
            System.Console.WriteLine("Elain nimi on" + " " + AsentanKoiran.PalautaNimi() + " " + "ja" + " " + "ikä on" + " " + AsentanKoiran.PalautaIka() + " " + "ja Lihansyoja" + " " + "on" + " " + AsentanKoiran.PalautaOnLihanSyoja());
          
            Elain koira_sound = new Koira(); //dog object
            Elain kissa_sound = new Kissa();
            Elain mammal_sound = new Nisakkaat();
            mammal_sound.Aantele();
            koira_sound.Aantele();
            kissa_sound.Aantele();

            Papukaija ominaisuudet = new Papukaija();
            ominaisuudet.Eat();
            
            Nisakkaat koira_offSpring = new Koira();
            koira_offSpring.OffSpring();

            Nisakkaat kissa_BodyCovering = new Kissa();
            kissa_BodyCovering.BodyCovering();                         
                       
        }
    }

}
