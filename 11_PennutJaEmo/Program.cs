using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KissatJaEmo
{
    /** 
     Vaihe 1
     Tee pääohjelmassa kissa olio.
     Tee LisääPentu-metodissa kissalle pentu (uusi kissa olio) ja lisää se pennut listaan. 
     Pääohjelma voisi näyttää tältä
     Kissa kissa1 = new Kissa();
     Kissa kissa2 = new Kissa();
     Kissa kissa1.LisaaPentu(); // kertaa kolme
     Kissa kissa2.LisaaPentu(); // kertaa kaksi
  
     Tee pääohjelmassa lisää kissa olioita ja lisää jokaiselle kolme pentua.
     Tulosta pentujen lukumäärä. 
     Tulosta pentujen tiedot.
     
     Vaihe2
     Jos emo tietää pentunsa voiko pentu tietää emoaan? Lisää uusi konstruktori syntyvälle pennulle, jossa annetaan kissa olio -emo kentälle. 
     Käytä vaiheen kaksi luokkakaaviossa esitettyä uutta konstruktoria LisaaPentu metodissa. Miten voit viitata niin, että emo on juuri tämä olio, jonka metodia kutsutaan?

      **/



    public class Program
    {
        static void Main(string[] args)
        {

            // Create multiple cat objects
            Kissa motherkissa = new Kissa();
            motherkissa.LisaaPentu();
            motherkissa.LisaaPentu();
            motherkissa.LisaaPentu();

            //Printing pentujen lukumäärä
            System.Console.WriteLine("Pentujen lukumäärä: ");
            motherkissa.PentujenTiedot();

            //when get child then child.Emo will return motherKissa
            List<Kissa> children = motherkissa.Pennut;

            foreach (Kissa child in children)
            {
                if (child.Emo() == motherkissa)
                {
                    System.Console.WriteLine("child knows mother");
                }
                else
                {
                    System.Console.WriteLine("child don't know mother.");
                }
            }


        }
    }
}
