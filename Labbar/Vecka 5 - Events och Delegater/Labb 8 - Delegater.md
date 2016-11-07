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
* Använd StringConcatinator för att skapa en kommaseparerad string av alla strings i din string-array
* Använd NumberOperator för att:
	1. Addera alla nummer i din float-array
	2. Multiplicera alla nummer
* Skriv ut resultatet av allt i konsollen

## VG-Uppgifter
* Skapa modell-klassen Product med följande properties:
	* Id: int eller guid
	* Name: string
	* Price: float eller double
* Skapa en ProductManager med en Product-lista och lägg till några instanser av Product i listan
* Lägg till följande metoder i ProductManager:
	* FormatProductNames
		* Tar emot en StringConcatinator-delegat
		* Använder StringConcatinator för att returnera en läsbar string med alla produktnamn
	* PriceCalculation
		* Tar emot en NumberOperator-delegat
		* Använder NumberOperator för att utföra följande matematiska operationer och returnera resultatet:
			1. Addera alla priser och lägga på 20% på totalpriset
			2. 
* Fixa lite menyer så att man kan använda programmet