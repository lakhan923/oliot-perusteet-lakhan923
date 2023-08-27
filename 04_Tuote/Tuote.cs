using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Tuote
{
    public class Tuote
    {

       double hinta;
       int luku;
       string nimi;


       public Tuote(string nimiAlussa, double hintaAlussa, int maaraAlussa)
       {
           this.nimi = "Banaani";
           this.hinta = 1.1;
           this.luku = 13;
       }

       public void TulostaTuote()
       {
          
          System.Console.WriteLine(nimi + "," + " "+ "hinta" + hinta + "," +" "+luku + " " + "kpl");
       } 

    }
}