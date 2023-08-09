# 02_Maksukortti

Täydennä Maksukortti-luokkaa seuraavilla metodeilla:

```c#
public void SyoEdullisesti() { 
 // kirjoita koodia tähän 
}

public void SyoMaukkaasti() {
 // kirjoita koodia tähän
}
```
Metodin syoEdullisesti tulisi vähentää kortin saldoa 2.60 eurolla ja metodin syoMaukkaasti tulisi vähentää kortin saldoa 4.60 eurolla.

Seuraava pääohjelma testaa luokkaa:

```c#
public class Program { 
	public static void Main(string[] args) {
		Maksukortti kortti = new Maksukortti(50); 
		Console.WriteLine(kortti); 
		kortti.SyoEdullisesti();
		Console.WriteLine(kortti); 
		kortti.SyoMaukkaasti(); 
		kortti.SyoEdullisesti(); 
		Console.WriteLine(kortti);
	} 
}
```
Ohjelman tulisi tuottaa *kutakuinkin* seuraava tulostus:
Esimerkkitulostus

Kortilla on rahaa 50.0 euroa\
Kortilla on rahaa 47.4 euroa\ 
Kortilla on rahaa 40.199999999999996 euroa
