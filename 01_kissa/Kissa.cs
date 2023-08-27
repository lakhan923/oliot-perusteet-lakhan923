using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_kissa
{

    public class Kissa
    {

        private int ika; // privaatti attribuutti
        public string nimi; // julkinnen attribuutti

        public int Ika
        {
            get { return ika; }
            set { ika = 10; }
        }

        public override string ToString()
        {
            return "Kissa: " + nimi + "," + " " + "ikä" + " " + ika;
        }

        public Kissa() // <-- konstruktori
        {
            nimi = "Miuku";
            ika = 1;

        }

        public Kissa(int ika, string nimi) // <-- parametrillinen konstruktori
        {
            this.ika = ika;
            this.nimi = nimi;
        }

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
    }
}
