using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderElaimet
{
    class Elaintenlajittelija
    {
        static void Main(string[] args)
        {
            
            Vuoro();
            Jakojaannos();

        }


        // 1. tapa. Tutki jakojaannös % (modulo) opetaaraattorin käyttöä ja mieti voisiko se auttaa tehtävät ratkaisussa.
        // kun neljällä jaollinen, niin pitää olla hevonen
        // 1 mod 3 = 1, koska 0 + 0 * 3 + m = 1, joten m = 1
        // 2 mod 3 =2, koska 0 + 0 * 3 + m = 2, joten m = 2
        private static void Jakojaannos()
        {


        }

        // 2. Voit ajatella ongelmaa myös jonottamisen kautta. Eläimet pyörivät jonossa ja vaihtavat paikkaa. Ensimmäisenä ollut eläin
        // joutuu aina jonon perälle (hevonen on aina viimeinen) eli kolmanneksi. Toinen eläin on ensimmäinen seuraavalal kierroksella ja 
        // siirtyy jälleen kolmanneksi jne.
        private static void Vuoro()
        {
            int elainVuoro = 1;
  
            // Kissa, koira, papukaija, hevonen

            // kun neljällä jaollinen, niin pitää olla hevonen
            // 1 mod 3 = 1, koska 0 + 0 * 3 + m = 1, joten m = 1
            // 2 mod 3 =2, koska 0 + 0 * 3 + m = 2, joten m = 2

        }
    }
}
