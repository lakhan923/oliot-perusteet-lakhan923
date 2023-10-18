using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa : Nisakkaat //inherited the constructors from Elain for the Kissa class
    {
        protected string name{get ; set; }

        protected int age{get; set; }
        public string kehrays; // object variable

        public Kissa() : base()
        {
            this.kehrays = "";
            this.name = "Simba";
            this.age = 12;
        }

        public void Kehraa() // prints "hrrrr, hrrrr..." on the screen, but does not return anything
        {
            System.Console.WriteLine("hrrrr, hrrrr...");
        }

        // Polymorphism(means "many forms",it occurs when we have many classes that are related to each other by inheritance) and Overriding Methods
        public override void Aantele()
        {
            Console.WriteLine("Meow!");
        }

        public override void BodyCovering()
        {
            System.Console.WriteLine(name + " " + "is" + " " + age + " "+ "years old and her body is covered with \"Hairs or Fur.\"");
        }
    }
}