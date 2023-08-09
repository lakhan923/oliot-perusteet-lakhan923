# Luokkakirjastot ja periytyminen 3   
   
   1. Tee uudet luokat Nisakkaat, Linnut sekä Papukaija 

      + Tee jokaiselle oma tiedostot, jotka ovat samalla lailla solution-tason tiedostoja, kuten Koira ja Kissa ja Elain. 

      + Tee luokkiin seuraavat muutokset: 

           - Nisakkaat-luokka periytyy Elain-luokasta 

           - Linnut-luokka periytyy Elain-luokasta 

           - Koira- ja Kissa-luokat periytyvät Nisakkaat-luokasta 
  
           - Papukaija-luokka periytyy Linnut-luokasta 

 

2. Aja edellisen tehtävän ohjelma uudestaan. Ohjelman pitäisi toimia vaikka luokat muuttuivat. 

3. Yläluokan metodin korvaaminen. Jokainen eläin ääntelee käskettäessä. 
    + Luo  eläin luokalle metodi Aantele(), joka palauttaa tekstin Umph!  
    + Testaa koiran ääntelyä. Pitäisi tulla "Umph!". Hyödynnä override ja virtual metodeja ja korvaa koira luokassa Aantele() -metodi niin, että se tulostaa "Hau!" ja kissalla "Miau!". 
    + Luo tämän jälkeen eläin, nisakas, kissa ja koira oliot ja kutsu jokaisen Aantele() metodia.  
    + Vertaile tulostuksia.  

Ohjelmassamme emme tule luomaan yhtään Eläin, Nisakkaat tai Linnut luokan oliota, vaan kaikki oliot ovat jostain aliluokasta. Luo pääohjelmassa yksi Elain olio. Pitäisi toimia. Lisätään yläluokkien eteen abstract määre. 
Tämä tekee luokasta abstraktin ja siitä ei voi enää synnyttää olioita. Tällä estetään luokkarakenteen vääränlainen käyttö.   

    Luokkien hierarkia: 

              Elain 

           /           \ 

    Nisakkaat           Linnut 

    /       \          \       \ 

    Koira   Kissa   Hevonen     Papukaija 

 

## Esimerkki abstract määreestä: 


namespace AbstractClasses  

{  

class Program  

{  

static void Main(string[] args)  

{ 

Dog dog = new Dog()

Console.WriteLine(dog.Describe());  

Console.ReadKey();  

}  

}  

abstract class FourLeggedAnimal  

{  

public virtual string Describe()  

{  

return "Not much is known about this four legged animal!";  

}  

}  

class Dog : FourLeggedAnimal 

 {  

 

}  

} 

 

Lisätietoa https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members 
