## Musiikkikappale

Luo uusi projekti tai käytä annettua projektia.

1. Luo projektiin luokka nimeltä Musiikkikappale.
2. Musiikkikappaleella on oliomuuttujat nimi (merkkijono) ja pituus sekunteina (kokonaisluku).
3. Molemmat asetetaan konstruktorissa public Musiikkikappale(string kappaleenNimi, int kappaleenPituus).
4. Lisää oliolle myös metodit public string Nimi(), joka palauttaa kappaleen nimen, ja public int Pituus(), joka palauttaa kappaleen pituuden.

Luokan tulee toimia seuraavasti.
```c#
Musiikkikappale garden = new Musiikkikappale("In The Garden", 10910); 
Console.Writeline("Kappaleen " + garden.Nimi() + " pituus on " + garden.Pituus() + " sekuntia.");
```
Esimerkkitulostus

Kappaleen In The Garden pituus on 10910 sekuntia.
