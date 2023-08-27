using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Velka
{
    public class Velka
    {
        double saldo;
        double korkoProsentti;
        public Velka(double saldoAlussa, double korkoProsentti)
        {
            this.saldo = saldoAlussa;
            this.korkoProsentti = korkoProsentti;
        }
        public void TulostaSaldo()
        {
            System.Console.WriteLine(saldo);
        }

        public void OdotaVuosi()
        {
            saldo = saldo * (1+ korkoProsentti);
        }
    }
}