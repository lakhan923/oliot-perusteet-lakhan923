using System;
using System.IO;
using System.Data;
using System.IO.Enumeration;

class Program
{
    public static void Main(string[] args)
    {
        TiedostonKäsittelyä tiedoston = new TiedostonKäsittelyä();
         System.Console.WriteLine("Anna tiedoston nimi: ");
        string tiedostonNimi = Console.ReadLine();
        File.WriteAllText(tiedostonNimi, "\"Hello World!\"\n\"Uusi rivi tässä.\"");
        string tiedostoSisalto = File.ReadAllText(tiedostonNimi);
        Console.WriteLine(tiedostoSisalto);

        bool fileExists = tiedoston.OnkoTiedostonOlemassa(tiedostonNimi);
        if (fileExists)
        {
            string strings = tiedoston.LueTiedostoMerkkiJonot(tiedostonNimi);
            Console.WriteLine("\nMerkkijonoksi:");
            Console.WriteLine(strings);

            string[] tables = tiedoston.LueTiedostoTaulukot(tiedostonNimi);
            Console.WriteLine("\nTaulukkoksi:");
            foreach (string table in tables)
            {
                Console.WriteLine(table);
            }

            List<string> lists = tiedoston.LueTiedostoListat(tiedostonNimi);
            Console.WriteLine("\nListaksi:");
            foreach (string list in lists)
            {
                Console.WriteLine(list);
            }
        }

        // 1   open the text file text1.txt for post-writing. The old content of the file is preserved when opening and writing starts from the end of the file.
        //     print the already existing contents of the file. Do section 12.3. one or more new methods from the line reading code if necessary.
        // 2   add the line "Huahaa!" to the file
        // 3   close the file
        using (StreamWriter writer = File.AppendText(tiedostonNimi))
        {

            writer.WriteLine("\n\"Huahaa.\"");
            writer.Close();
        }


        // 1 reopen the text file for reading only
        // 2 read and print the contents of the file line by line
        // 3 close the file
        using (StreamReader reader = new StreamReader(tiedostonNimi))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }
        }

        using (StreamReader reader = new StreamReader(tiedostonNimi))
        {
            int merkki;
            string result = "";

            // Read characters one by one
            while ((merkki = reader.Read()) != -1)
            {
                // Append the character to the result
                result += (char)merkki + ",";
            }
            Console.WriteLine(result);
        }

        string binaariFile = "munbinaari.bin";
        BinaryWriter bwStream = new BinaryWriter(new FileStream(binaariFile, FileMode.Create));
        bwStream.Write(3.14159265);
        bwStream.Write(-1);
        bwStream.Close();

        FileStream fileStream = new FileStream(binaariFile, FileMode.Open, FileAccess.Read);
        using (BinaryReader reader = new BinaryReader(fileStream))
        {

            double d = reader.ReadDouble();
            int i = reader.ReadInt32();
            reader.Close();
        }

        DirectoryInfo directories = new DirectoryInfo("/home/isfandyarkhan/oliot-perusteet-lakhan923/12_Tiedostojenkasittely/Class_File");
        FileInfo[] Files = directories.GetFiles();
        System.Console.WriteLine("content of the directory\n");
        foreach (FileInfo file in Files)
        {
            Console.WriteLine("File Name : {0}", file.Name);
        }

    }
}
