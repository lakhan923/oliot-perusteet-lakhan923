using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Linnut : Elain
    {
        public Linnut() : base()
        {
           
        }

        public Linnut(int ika, string nimi) : base(ika, nimi)
        {
         
        }

        public virtual void Eat()
        {
            System.Console.WriteLine("finch");
        }

        

    }
}