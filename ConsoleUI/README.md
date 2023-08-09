# Projektissa on komentoriviohjelma, jossa on tällä hetkellä 2 komentoa clear ja exit. Testaa ohjelman toimintaa

1. Perehdy projektissa olevaan valmiiseen koodiin. Uusi kohtia:
2. 
	Interface
	
	https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces
Selvitä itsellesi miten ohjelma toimii.
	

2. Tee uusi komento about, joka toteuttaa ICommand -luokan.  About tulostaa tekijän nimen esim. Made by Jussi. Kun tämä toimii, lisää siihen atribuutit s ja f jolloin tulostetaan sama myös suomeksi ja ruotsiksi.

Esimerkkitulostus
```
ConsoleUI v.1.0.0.0
>>> about
[about] Made by Jussi
>>> about f
[about] Made by Jussi
        Tekijä on Jussi
>>> about f s
[about] Made by Jussi
        Tekijä on Jussi
        Upphovsman är Jussi
```
3. Lisää vielä yksi uusi komento ?, joka tulostaa kaikki mahdolliset komennot ja niiden HelpTextin.

Esimerkkitulostus
```
ConsoleUI v.1.0.0.0
>>> ?
[clear]	Clears the console screen.
[exit]	Exit ConsolePlus instance.
[about]	Prints developer. Possible atributes:
		-f Shows text also in Finnish
		-s Shows text also in Swedish
>>>
```
