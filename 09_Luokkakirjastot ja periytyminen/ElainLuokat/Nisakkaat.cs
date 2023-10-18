using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Nisakkaat : Elain
    {
        // public bool giveMilk; // example

        public Nisakkaat() : base()
        {
            // giveMilk = true;
            // Console.WriteLine("In Nisakkaat default contructor");
            
        }

        public Nisakkaat(int ika, string nimi) : base(ika, nimi)
        {
            
        }

        public virtual void OffSpring()
        {
            System.Console.WriteLine("Live Birth");
        }

        public virtual void BodyCovering()
        {
            System.Console.WriteLine("Hair or Fur");
        } 
           
        // public override string ToString()
        // {
        //     return base.ToString() + "  give milk =" + giveMilk;
        // }


    }
}