﻿using System;

namespace _06_Musiikkikappale
{
    class Program
    {
        static void Main(string[] args)
        {
            Musiikkikappale garden = new Musiikkikappale("In The Garden", 10910);
            Console.WriteLine("Kappaleen " + garden.Nimi() + " pituus on " + garden.Pituus() + " sekuntia.");
        }
    }
}
