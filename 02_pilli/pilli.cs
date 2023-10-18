using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_pilli
{
    public class Pilli
    {
        private string aani;

        public void Soi()
        {
            System.Console.Write(aani);
        }

        public Pilli(string pillinAani)
        {
            this.aani = pillinAani;
        }


    }
}