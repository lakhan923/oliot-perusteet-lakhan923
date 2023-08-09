# 03_Maksukortti

Mitä tapahtuu, jos kortilta loppuu raha kesken? Ei ole järkevää, että saldo muuttuu negatiiviseksi. Muuta metodeita SyoEdullisesti ja SyoMaukkaasti niin, että ne eivät vähennä saldoa, jos saldo menisi negatiiviseksi.

Seuraava pääohjelma testaa luokkaa:

```c#
public class Program {
	public static void Main(string[] args) { 
		Maksukortti kortti = new Maksukortti(5); 
		Console.WriteLine(kortti); 
		kortti.SyoMaukkaasti(); 
		Console.WriteLine(kortti); 
		kortti.SyoMaukkaasti(); 
		console.WriteLine(kortti);
	}
}
```
Ohjelman tulisi tuottaa seuraava tulostus:
Esimerkkitulostus

Kortilla on rahaa 5.0 euroa\
Kortilla on rahaa 0.40000000000000036\
Kortilla on rahaa 0.40000000000000036

Yllä toinen metodin SyoMaukkaasti kutsu ei vaikuttanut saldoon, koska saldo olisi mennyt negatiiviseksi.
