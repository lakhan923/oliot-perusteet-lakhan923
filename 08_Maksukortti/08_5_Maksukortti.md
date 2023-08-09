# 05_Maksukortti

Muuta metodia lataaRahaa vielä siten, että jos yritetään ladata negatiivinen rahamäärä, ei kortilla oleva arvo muutu.

Seuraava pääohjelma testaa luokkaa:

```c#
public class Program { 
	public static void Main(string[] args) { 
		Maksukortti kortti = new Maksukortti(10);
		Console.WriteLine("Pekka: " + kortti); 
		kortti.lataaRahaa(-15);
		Console.WriteLine("Pekka: " + kortti); 
	} 
}
```

Ohjelman tulisi tuottaa seuraava tulostus:

Pekka: Kortilla on rahaa 10.0 euroa\
Pekka: Kortilla on rahaa 10.0 euroa
