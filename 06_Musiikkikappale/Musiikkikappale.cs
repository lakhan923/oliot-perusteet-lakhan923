using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Musiikkikappale
{
    public class Musiikkikappale
    {
        string nimi;
        int pituus;

        public Musiikkikappale(string kappaleenNimi, int kappaleenPituus)
        {
            this.nimi = kappaleenNimi;
            this.pituus = kappaleenPituus;
        }

        public string Nimi()
        {
            return nimi;
        }

        public int Pituus()
        {
           return pituus;
        }

    }
}