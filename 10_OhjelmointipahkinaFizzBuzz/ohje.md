# Ohjelmointihaaste "kissa-koira-papukaija-hevonen"

## Vaihe 1 

Luo uusi projekti olemassa olevaan solutioniin ja viittaa siitä ElainLuokat-kirjastoon (etsi .dll bin-kansiosta) ja lisää sinne hevonen luokka, hierarkian mukaan oikein.

## Vaihe 2  

Kysy käyttäjältä luotavien eläinten määrää.

## Vaihe 3  

Tee silmukka, jossa luot kysytyn määrän olioita seuraavin ehdoin (lisää ohjeita ja vinkkejä löytyy solutionista): 

       - joka kolmas on kissa 
       - joka kolmas on koira 
       - joka kolmas on papukaija 

Paitsi joka neljäs eläin on aina hevonen ja se korvaa vuorossa olevan eläimen. Lisää jokainen eläin SAMAAN List-tietorakenteeseen. Vihje: Ei kannata miettiä aluksi listaan lisäämistä vaan saada logiikka toimimaan esim. Tulostaen halutut arvot. 

         Eli jos silmukka pyörähtää 12 kertaa, luodaan 

             kissa 
             koira 
             papukaija 
             hevonen 
             koira 
             papukaija 
             kissa 
             hevonen 
             papukaija 
             kissa 
             koira 
             hevonen 

Huom! Ohjelman pitää toimia myös, jos käyttäjä antaa yli 12 kierrosta. 

        Generoi myös arvot: 

             - nimi 
             - ikä 
## Vaihe 4  

Käy ensimmäisen silmukan jälkeen toisessa silmukassa Lista läpi ja tulosta jokaisen eläimen **yhteiset** tiedot.  

## Vaihe 5

+ Lisää jokaiselle luokalle (Koira, Kissa, Papukaija, Hevonen) oma uniikki atribuutti esim. Koira luokalle oma atribuutti bool ihmisenParasYstava = true;

+ Tulosta seuraavaksi jokaisen olion **kaikki** tiedot. 

**Vinkki! Voit käydä eri tyyppisiä oliota läpi rajaamalla silmukat tiettyihin tyyppeihin**

```c#

 foreach (aliluokka olio in lista.OfType<aliluokka>()) 
```
HUOM! Lähtökohtaisesti kerjää vaikeuksia laittamalla erityyppisiä olioita samaan listaan. Yleensä kannattaa laittaa kukin luokka omaan listaansa.  
