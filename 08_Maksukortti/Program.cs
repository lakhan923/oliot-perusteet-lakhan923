using System;

namespace _08_Maksukortti
{
    class Program
    {
        static void Main(string[] args)
        {

            // Maksukortti kortti = new Maksukortti(50);
            // Console.WriteLine(kortti);


            //Reducing the card balance by 2.60 euros and 4.60 euros.

            // Maksukortti kortti = new Maksukortti(50);
            // Console.WriteLine(kortti);
            // kortti.SyoEdullisesti();
            // Console.WriteLine(kortti);
            // kortti.SyoMaukkaasti();
            // kortti.SyoEdullisesti();
            // Console.WriteLine(kortti);

            //Changing the methods SyoEdulistily and SyoMaukkaasti...
            // so that they do not reduce the balance if the balance goes negative.

            // Maksukortti kortti = new Maksukortti(5);
            // Console.WriteLine(kortti);
            // kortti.SyoMaukkaasti();
            // Console.WriteLine(kortti);
            // kortti.SyoMaukkaasti();
            // console.WriteLine(kortti);

            //increasing the balance by the given number(10).

            // Maksukortti kortti = new Maksukortti(10);
            // Console.WriteLine(kortti);
            // kortti.LataaRahaa(15);
            // Console.WriteLine(kortti);
            // kortti.LataaRahaa(10);
            // Console.WriteLine(kortti);
            // kortti.LataaRahaa(200);
            // Console.WriteLine(kortti);

            //Changing the method LataaRahaaa,so that if we try to load a negative amount of money,
            // the value on the card does not change.

            // Maksukortti kortti = new Maksukortti(10);
            // Console.WriteLine("Pekka: " + kortti);
            // kortti.LataaRahaa(-15);
            // Console.WriteLine("Pekka: " + kortti);

            // Last step
            Maksukortti pekanKortti = new Maksukortti(20);
            Maksukortti matinKortti = new Maksukortti(alkusaldo: 30);

            pekanKortti.SyoMaukkaasti();
            System.Console.WriteLine("Pekka: " + pekanKortti);

            matinKortti.SyoEdullisesti();
            System.Console.WriteLine("Matti: " + matinKortti);
            
            pekanKortti.LataaRahaa(20);
            System.Console.WriteLine("Pekka: " + pekanKortti);

            matinKortti.SyoMaukkaasti();
            System.Console.WriteLine("Matti: " + matinKortti);

            pekanKortti.SyoEdullisesti();
            pekanKortti.SyoEdullisesti();
            System.Console.WriteLine("Pekka: " + pekanKortti);

            matinKortti.LataaRahaa(50);
            System.Console.WriteLine("Matti: " + matinKortti);    

        }

    }
}
