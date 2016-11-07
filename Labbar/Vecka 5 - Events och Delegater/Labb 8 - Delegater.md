# Labb 8 - Delegater
## G-Uppgifter
* Skapa delegater:
	* StringConcatinator
		* Tar emot en string-collection (typ array eller list)
		* Returnerar en string
	* NumberOperator
		* Tar emot en float-collection
		* Returnerar en float
* Skapa instanser av StringConcatinator och NumberOperator
* Skapa en string-array och en float-array
* Anv�nd StringConcatinator f�r att skapa en kommaseparerad string av alla strings i din string-array
* Anv�nd NumberOperator f�r att:
	1. Addera alla nummer i din float-array
	2. Multiplicera alla nummer
* Skriv ut resultatet av allt i konsollen

## VG-Uppgifter
* Skapa modell-klassen Product med f�ljande properties:
	* Id: int eller guid
	* Name: string
	* Price: float eller double
* Skapa en ProductManager med en Product-lista och l�gg till n�gra instanser av Product i listan
* L�gg till f�ljande metoder i ProductManager:
	* FormatProductNames
		* Tar emot en StringConcatinator-delegat
		* Anv�nder StringConcatinator f�r att returnera en l�sbar string med alla produktnamn
	* PriceCalculation
		* Tar emot en NumberOperator-delegat
		* Anv�nder NumberOperator f�r att utf�ra f�ljande matematiska operationer och returnera resultatet:
			1. Addera alla priser och l�gga p� 20% p� totalpriset
			2. 
* Fixa lite menyer s� att man kan anv�nda programmet