using System;
using System.Dynamic;

namespace _01_kissa
{
    class Program
    {
        /// <summary>
        ///  creating a class and then further developing that class
        /// </summary>
        /// <param age="1">printts age</param>
        /// <summary>
        ///  The program prints "Miuku, ikä 1".
        /// </summary>
        /// <param name="Miuku">prints name</param>
        static void Main(string[] args)
        {

            // Kissa mykissa = new Kissa();
            // mykissa.nimi = "Viiru";
            // System.Console.WriteLine("Kissan nimi on: " + mykissa.nimi);

            // mykissa.nimi = "Simba";
            // System.Console.WriteLine("Kissan nimi on: " + mykissa.nimi);

            // Kissa kissan_ika = new Kissa();
            // kissan_ika.Ika = 10;
            // System.Console.WriteLine("Kissan ika on: " + kissan_ika.Ika);

            Kissa Katti = new Kissa();
            System.Console.WriteLine(Katti);
           

        // checking for cat's name.

            // Kissa Checking = new Kissa();
            // bool kissan_nimen_asettaminen = Checking.AsetaKissanNimi("Hilda");
            // System.Console.WriteLine(kissan_nimen_asettaminen);
            
        //how to call a method on an object and store the return value in a variable.
        //return type of the called method is boolean thats why declaring a boolean variable here.                                           
           
            // bool kissan_ian_asettaminen = Checking.AsetaKissanIka(1);
            // System.Console.WriteLine(kissan_ian_asettaminen);
            

       
            
            
        }

    }
}
