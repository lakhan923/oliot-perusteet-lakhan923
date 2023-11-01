using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Koira : Nisakkaat //inherited the constructors from Elain for the Koira class
    {
        protected string name { get; set; }

        protected int age { get; set; }

        public string haukku; // object variable (Attribute)
        public bool HumansBestFriend { get; set; }

        public Koira() : base()
        {
            this.haukku = "";
            this.name = "Daisy";
            this.age = 10;
            //Console.WriteLine("In koira default contructor"); //example
        }

        public void Haukku() // prints the value of the Bark field on the screen
        {
            System.Console.WriteLine("woof woof");
        }

        // Polymorphism(means "many forms",it occurs when we have many classes that are related to each other by inheritance) and Overriding Methods
        public override void Aantele()
        {
            Console.WriteLine("Hau!");
        }

        public override void OffSpring()
        {
            System.Console.WriteLine(name + " " + "is" + " " + age + " " + "years old and gives \"Live Birth.\"");
        }


    }
}