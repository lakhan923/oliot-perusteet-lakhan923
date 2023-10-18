using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Papukaija : Linnut
    {
        protected string name{get ; set; }

        protected int age{get; set; }
 
        public string eat;

        public Papukaija() : base()
        {
            this.eat = "";
            this.name = "Parrot";
            this.age = 9;
        }

        public override void Eat()
        {
            Console.WriteLine(name + " " + "is" + " " + age + " "+ "years old and eats Nuts.");
        }

    }
}