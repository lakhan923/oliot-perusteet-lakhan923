# 01_Kissa: Luokan luominen

## Vaihe 1 

	Luo projektiin uusi Kissa.cs -luokkatiedosto 

		1. Valitse projektisi Solutionin alta oikealla hiirenpainikkeella 
		2. Sieltä Add 
		3. Sieltä New Item 
		4. Sieltä New Class  
		5. Nimeä tiedosto Kissa.cs 
		6. Tallenna 
		
	Tulet käyttämään samaa Kissa.cs-tiedostoa useammassa tehtävässä. 


## Vaihe 2 

	Muokka Kissa.cs-tiedostoa ja tee Kissa-luokkaan ominaisuudet: 

      Huom! Älä käytä ääkkösiä! Voit tehdä myös englanniksi. 

      Attribuutit: 

       - kissan ikä (private, valitse oikea tietotyyppi) 
       - kissan nimi (public, valitse oikea tietotyyppi) 

      Konstruktorit: 

       - Parametriton konstruktori 
       - Parametrillinen konstruktori, joka: 
          - asettaa kissan iän 
          - asettaa kissan nimen 

      Funktiot oikeine parametreineen ja paluumuuttujineen (public): 
       - public AsetaKissanNimi(<parameterina kissan nimi>) - tallentaa kissan nimen public-muuttujaan 
       - public <tietotyyppi>PalautaKissanNimi() - palauttaa kissan nimen (return)
       - public <tietotyyppi> PalautaKissanIka() - palauttaa kissan iän (return)


```c#

	public class Kissa // Luokan nimi
	{
		private int ika; // privaatti attribuutti
		public string // julkinnen attribuutti
		
		public Kissa() // <-- konstruktori
		{
		
		}
		public Kissa(int ika, string nimi) // <-- parametrillinen konstruktori
		{
			this.ika=ika;
			this.nimi=nimi;
		}
		public void AsetaKissanNimi(string nimi ) // metodi
		{
			this.nimi=nimi;
		}
```
## Vaihe 3 

	1. Ota Uusi Kissa-luokka Program.cs:ssä käyttöön luomalla uusi kissa-olio parametrittomalla konstruktorilla. 
	2. Anna sen jälkeen kissalle nimi suoraan public muuttujalla. 
	3. Tulosta kissan nimi. 
	4. Anna kissalle uusi nimi public -metodilla 
	5. Tulosta kissan nimi. 
	6. Tulosta kissan ikä. 
	7. Tee uusi kissa-olio ja anna ikä ja nimi konstruktorissa. 
	8. Tulosta uuden olion tiedot nimi ja ikä. 

[Siirry tehtävän seuraavaan vaiheeseen](02_kissa.md)
