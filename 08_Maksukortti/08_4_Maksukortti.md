# 04_Maksukortti

Lisätään luokkaan LataaRahaa metodi, jolla saa lisättyä saldoa annetun luvun verran.

Ominaisuuden testaava pääohjelma:

```c#
public class Program {
	public static void Main(string[] args) {
		Maksukortti kortti = new Maksukortti(10);		
		Console.WriteLine(kortti); 
		kortti.LataaRahaa(15);
		Console.WriteLine(kortti); 
		kortti.LataaRahaa(10); 
		Console.WriteLine(kortti); 
		kortti.LataaRahaa(200); 
		Console.WriteLine(kortti); 
	} 
}
```
Ohjelman tulisi tuottaa seuraava tulostus:

Kortilla on rahaa 10.0 euroa\
Kortilla on rahaa 25.0 euroa\
Kortilla on rahaa 35.0 euroa\
Kortilla on rahaa 235.0 euroa
