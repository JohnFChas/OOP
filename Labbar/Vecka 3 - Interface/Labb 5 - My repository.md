# Labb 5 - My repository
Du ska i den här labben bygga ett system i samma anda som det vi byggde tillsammans i Interface-workshoppen men du ska få klura ut själva vilka typer av objekt du vill använda.
### Saker att tänka på
* Skapa passande mappar för dina klasser, vi vill inte se mer än max 3-4 klasser i projekt-roten
* Tänk objektorienterat:
	* Passar det att använda arv i applikationen?
	* Inkapsling; vad ska ligga var?
* Använd workshoppen som ett exempel på hur du kan strukturera ditt projekt
### Del 1
* Tänk ut minst 2 olika modeller (klasser) som du vill att programmet ska jobba med (tex böcker, filmer, kläder etc)
* Skapa ett repository-interface
* Skapa ett repository som implementerar interfacet
* Skapa en klass där du har dina listor (som DataStore i exemplet)
* Skapa en Controller för varje modell, till exempel BooksController, MoviesController etc

### Del 2
* Ditt repository ska kunna:
	1. Lägga till saker i rätt lista
	2. Ta bort saker från rätt lista
	3. Redigera saker i listorna
	4. Visa listornas innehåll
* Dina Controllers ska ha varsin privat instans av ditt repository
* Genom att kalla en Controller ska programmet utföra ovanstående uppgifter med hjälp av sitt repository

### Extrauppgift (om allt annat är klart och du har tid över)
* Spara din data till någon sorts fil istället för att bara jobba mot en lista
* Se till att update fortfarande funkar