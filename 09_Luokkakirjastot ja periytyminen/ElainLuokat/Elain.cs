namespace ElainLuokat
{
    public class Elain // Abstract class is a restricted class that cannot be used to create objects 
    // (to access it, it must be inherited from another class)
    //it provide a common definition of a base class that multiple derived classes can share
    {
        private int ika; // privaatti attribuutti
        private string nimi;
        public bool _onLihanSyoja; // private object variable
        public string Nimi { get; set; }
        public int Ika { get; set; }

        //Getting and setting age
        public int GetIka()
        {
            return ika;
        }
        public void SetIka(int ika)
        {
            this.ika = ika;
        }

        //getting and setting name
        public string GetNimi()
        {
            return nimi;
        }
        public void SetNimi(string nimi)
        {
            this.nimi = nimi;
        }

        // return the data of the creature
        public override string ToString()
        {
            return "Elain nimi on" + " " + nimi + " " + "ja" + " " + "ikä on" + " " + ika + " " + "ja Lihansyoja" + " " + _onLihanSyoja;
        }

        public Elain() // <-- konstruktori
        {
            this.nimi = "Pekka";
            this.ika = 5;
            // Console.WriteLine("In Elain default contructor");//example

        }

        public Elain(int ika, string nimi) // <-- parametrillinen konstruktori
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        // returns a bool, takes an integer as a parameter and checks if the number is negative
        public bool AsetaKissanIka(int uusiIka)
        {
            this.ika = uusiIka;
            if (uusiIka < 0)
            {
                System.Console.WriteLine("ikää ei ole asetettu.");
                return false;
            }
            else
            {
                ika = uusiIka;
                return true;
            }
        }

        // returns nothing and takes as a parameter the text that is set in the object variable
        public bool AsetaKissanNimi(string uusiNimi)
        {
            this.nimi = uusiNimi;
            if (uusiNimi == "Hilda")
            {
                return false;
            }
            else
            {
                nimi = uusiNimi;
                return true;
            }

        }

        //returns an int and has no parameters
        public int PalautaIka()
        {
            return ika;
        }

        // returns the text and takes no parameters
        public string PalautaNimi()
        {
            return nimi;
        }


        public void AsetaOnLihanSyoja(bool carnivore)
        {
            _onLihanSyoja = carnivore;

        }

        public bool PalautaOnLihanSyoja()
        {
            return _onLihanSyoja;
        }


        //to override the base class method, by adding the virtual
        public virtual void Aantele()
        {
            System.Console.WriteLine("Umph!");
        }

    }
}