# Labb 7 - Store app
Du ska bygga en applikation f�r att underh�lla en aff�r!
### Uppgifter
* Skapa klassen Product
* Skapa klasser f�r produktkategorier, till exempel:
	* Electronics
	* Food
	* Toys
	* Du f�r best�mma sj�lv vad f�r typ av aff�r det ska vara och vilka kategorier som ska finnas!
* Skapa interfacet ISellable
* ISellable ska ha n�gra properties, till exempel:
	* Price
	* ProductInformation
* Product ska implementera ISellable och varje kategori ska �rva Product
* Programmet ska kunna:
	* Visa h�rdkodade produkter per kategori med relevant information

### Extrauppgifter
* Programmet ska �ven kunna:
	* L�ta anv�ndaren dynamiskt skapa instanser av produktkategorierna (l�gga till nya varor i registret)
	* Ta bort gamla objekt
	* L�gga till existerande produkter i en kundvagn
		* Man ska kunna se sin kundvagn och totalsumman av alla best�llda produkters pris

