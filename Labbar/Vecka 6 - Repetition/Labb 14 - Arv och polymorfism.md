# Labb 14 - Klasser, objekt, arv och polymorfism
## Uppgifter
* Skapa klassen Person med properties:
	* Name: string
	* Age: int
* Skapa klassen Author och låt den ärva av Person
* Skapa klassen Publication med properties:
	* Title: string
	* Author: Author
	* ReleaseDate: DateTime
* Skapa klassen Book och låt den ärva av Publication, ge den egna properties:
	* Genre: string (eller enum)
	* Pages: int
* Skapa även följande klasser och låt dem ärva av Publication:
	* Magazine
	* Paper
* Skapa en instans av varje klass som ärver av Publication
* Skapa några instanser av klassen Author
* Se till att varje Publications Author property refererar en instans av Author

## Extrauppgifter
* Skapa listor för alla typer av publications och fyll dem med objekt
* Skapa en lista för Author och fyll den med objekt
* Varje Publications Author property ska referera en Author i listan
* Låt användaren söka på en Authors namn och hämta alla Publications för den Authorn, använd gärna LINQ
