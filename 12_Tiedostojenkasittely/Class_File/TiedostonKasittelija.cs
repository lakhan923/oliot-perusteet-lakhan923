using System.Linq;
using System;
using System.IO;
using System.Data;
class TiedostonKäsittelyä
{
    public TiedostonKäsittelyä()
    {

    }

    public bool OnkoTiedostonOlemassa(string x)
    {
        bool tiedostoOlemassa = File.Exists(x);
        if (tiedostoOlemassa)
        {
            System.Console.WriteLine(tiedostoOlemassa + " " + "Tiedosto on olemassa");

        }
        else
        {
            System.Console.WriteLine(tiedostoOlemassa + " " + "Tiedosto ei ole olemassa");

        }
        return tiedostoOlemassa;
    }

    public string LueTiedostoMerkkiJonot(string filename)
    {
        string lines = File.ReadAllText(filename);
        return lines;
    }

    public string[] LueTiedostoTaulukot(string filename)
    {
        string[] columns = File.ReadAllLines(filename);
        return columns;

    }

    public List<string> LueTiedostoListat(string filename)
    {
        List<string> files = File.ReadAllLines(filename).ToList();
        return files;

    }
}