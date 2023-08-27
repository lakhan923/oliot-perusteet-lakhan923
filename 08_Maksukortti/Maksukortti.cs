using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_Maksukortti
{
    public class Maksukortti
    {
        private double saldo;
        public Maksukortti(double alkusaldo)
        {
            saldo = alkusaldo;
        }

        public override String ToString()
        {
            return "Kortilla on rahaa" + " " + saldo + " " + "euroa";
        }

        public void SyoEdullisesti()
        {           
           saldo = saldo - 2.60;            
        }

        public void SyoMaukkaasti()
        {            
            double check = saldo - 4.60;
            if (check > 0)
            {
                saldo = saldo - 4.60;
            }
        }

        public double LataaRahaa(double number)
        {
            // For increasing the balance by 10.

            saldo += number;
            return saldo;

            // For loading a negative amount of money,the value on the card does not change.

            // double x = saldo -15;
            // if(x > 0)
            // {
            //     saldo = saldo - 15;
            // }
            // return x;



        }
    }
}