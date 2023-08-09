  # Luokkakirjastot ja periytyminen 1
  
Luokat ovat käytössä vain siinä nimiavaruudessa missä ne on esitelty. Ohjelman luettavuuden takia, jokainen luokka kannattaa pitää omassa cs -tiedostossaan, mutta voimme luoda luokkakirjaston kaikille luokille. Yleiskäyttöistä luokkakirjastoa voidaan hyödyntää useissa ohjelmissa. 

Luo uusi solution ja valitse projektin tyypiksi .net Class Library. Nimeä kirjasto ElainLuokat -nimiseksi. 
   
#### 1. Tee luokkakirjastoon ElainLuokat uusi Luokka Elain. 

   + Valitse luokkakirjasto oikealla hiirellä 

   + Sieltä Add 

   + Sieltä New Item 

   + Sieltä New Class  

   + Nimeä tiedosto Elain.cs 

   + Tallenna 

 #### 2.Lisää aikaisempien eläinten (kissa/koira) yhteiset ominaisuudet Elain-luokkaan(ks. tehtävä 01_Kissa, ja ota sieltä pohjakoodit).

 - Attribuutit ikä ja nimi 
 - Parametriton ja parametrillinen konstruktori
 
#### 3. Luo uudet Public metodit: 

   - AsetaIka(), joka palauttaa bool:n, ottaa parametrina kokonaisluvun ja tarkistaa onko luku negatiivinen 

   - AsetaNimi, ei palauta mitään ja ottaa parametrina tekstin, joka asetetaan oliomuuttujaan

   - PalautaIka, palauttaa int:n, eikä ole parametreja

   - PalautaNimi, palauttaa tekstin, eikä ota parametreja
   
   - override string ToString(), jossa palautat elaimen tiedot.
Esimerkki teksti "Eläimen nimi on Pekka ja ikä on 5"

#### 4. Luo vain Elain-luokkaan uusi oliomuuttuja , joka on kaikille eläimille yhteinen

   - bool _onLihanSyoja 

#### 5. Tee metodit

   - AsetaOnLihanSyoja(<parametri>) 

   - bool PalautaOnLihanSyoja() 
  
   - Lisää myös lihansyöjän tieto ToString-metodin tekstiin.
