# Labb 14 - Klasser, objekt, arv och polymorfism
## Uppgifter
* Skapa klassen Person med generiska properties:
	* Name: string
	* Age: int
* Skapa klassen Author och l�t den �rva av Person
* Skapa klassen Publication med generiska properties:
	* Title: string
	* Author: Author
	* ReleaseDate: DateTime
* Skapa klassen Book och l�t den �rva av Publication, ge den egna properties:
	* Genre: string (eller enum)
	* Pages: int
* Skapa �ven f�ljande klasser och l�t dem �rva av Publication:
	* Magazine
	* Paper
* Skapa en instans av varje klass som �rver av Publication
* Skapa n�gra instanser av klassen Author
* Se till att varje Publications Author property refererar en instans av Author

## Extrauppgifter
* Skapa listor f�r alla typer av publications och fyll dem med objekt
* Skapa en lista f�r Author och fyll den med objekt
* Varje Publications Author property ska referera en Author i listan
* L�t anv�ndaren s�ka p� en Authors namn och h�mta alla Publications f�r den Authorn, anv�nd g�rna LINQ