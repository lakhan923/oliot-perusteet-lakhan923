## Tuote

Aloita uusi projekti (tai käytä tehtävässä annettua projektia).

1. Luo projektiin luokka Tuote, joka esittää kaupan tuotetta.
	a. Tuotteella tulee olla hinta (double), lukumäärä (int) ja nimi (string).

2. Tuote-luokalla tulee olla:
	a. Konstruktori public Tuote(string nimiAlussa, double hintaAlussa, int maaraAlussa)   
	b. Metodi public void TulostaTuote() joka tulostaa tuotteen tiedot tässä muodossa:
		Esimerkkitulostus
			Banaani, hinta 1.1, 13 kpl


3. Tuotteen tulee toimia seuraavasti.
```c#
Tuote aleTuote = new Tuote("banaani", 1.1, 13); 
aleTuote.TulostaTuote(); 

```

Esimerkkitulostus

Banaani, hinta 1.1, 13 kpl

