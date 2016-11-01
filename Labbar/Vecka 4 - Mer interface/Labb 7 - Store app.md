# Labb 7 - Store app
Du ska bygga en applikation för att underhålla en affär!
### Uppgifter
* Skapa klassen Product
* Skapa klasser för produktkategorier, till exempel:
	* Electronics
	* Food
	* Toys
	* Du får bestämma själv vad för typ av affär det ska vara och vilka kategorier som ska finnas!
* Skapa interfacet ISellable
* ISellable ska ha några properties, till exempel:
	* Price
	* ProductInformation
* Product ska implementera ISellable och varje kategori ska ärva Product
* Programmet ska kunna:
	* Visa hårdkodade produkter per kategori med relevant information

### Extrauppgifter
* Programmet ska även kunna:
	* Låta användaren dynamiskt skapa instanser av produktkategorierna (lägga till nya varor i registret)
	* Ta bort gamla objekt
	* Lägga till existerande produkter i en kundvagn
		* Man ska kunna se sin kundvagn och totalsumman av alla beställda produkters pris

