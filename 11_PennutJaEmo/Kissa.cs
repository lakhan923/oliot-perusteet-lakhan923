using System.Reflection.Metadata;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace KissatJaEmo
{
    class Kissa
    {
        private string _nimi;
        private int _ika = 0;
        private List<Kissa> _pennut = new List<Kissa>();
        private Kissa _emo;

        // Public property for name
        public string Nimi
        {
            get { return _nimi; }
            set { _nimi = value; }
        }

        // Public property for Age
        public int Ika
        {
            get { return _ika; }
            set { _ika = value; }
        }

        //public property for puppy
        public List<Kissa> Pennut
        {
            get { return _pennut; }
            set { _pennut = value; }
        }

        public Kissa()
        {

        }

        public Kissa(string nimi, int ika)
        {
            _nimi = nimi;
            _ika = ika;
        }

        public void PentujenTiedot()
        {
            System.Console.WriteLine("Pentujen tiedot:");
            foreach (Kissa pentu in _pennut)
            {
                System.Console.WriteLine("Nimi:" + " " + pentu._nimi + " " + "ja" + " " + " " + "Ika:" + " " + pentu._ika);
            }

        }

        public int LisaaPentu()
        {
            Kissa pentu = new Kissa("Kitten", ika: 0);
            pentu._emo = this; // "this" is the refernce to the object that is calling LisaaPentu 
            _pennut.Add(pentu);
            return _pennut.Count;
        }

        public Kissa Emo()
        {
            return _emo;
        }
    }
}
