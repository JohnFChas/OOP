# Labb 5 - My repository
Du ska i den h�r labben bygga ett system i samma anda som det vi byggde tillsammans i Interface-workshoppen men du ska f� klura ut sj�lva vilka typer av objekt du vill anv�nda.
### Saker att t�nka p�
* Skapa passande mappar f�r dina klasser, vi vill inte se mer �n max 3-4 klasser i projekt-roten
* T�nk objektorienterat:
	* Passar det att anv�nda arv i applikationen?
	* Inkapsling; vad ska ligga var?
* Anv�nd workshoppen som ett exempel p� hur du kan strukturera ditt projekt
### Del 1
* T�nk ut minst 2 olika modeller (klasser) som du vill att programmet ska jobba med (tex b�cker, filmer, kl�der etc)
* Skapa ett repository-interface
* Skapa ett repository som implementerar interfacet
* Skapa en klass d�r du har dina listor (som DataStore i exemplet)
* Skapa en Controller f�r varje modell, till exempel BooksController, MoviesController etc

### Del 2
* Ditt repository ska kunna:
	1. L�gga till saker i r�tt lista
	2. Ta bort saker fr�n r�tt lista
	3. Redigera saker i listorna
	4. Visa listornas inneh�ll
* Dina Controllers ska ha varsin privat instans av ditt repository
* Genom att kalla en Controller ska programmet utf�ra ovanst�ende uppgifter med hj�lp av sitt repository

### Extrauppgift (om allt annat �r klart och du har tid �ver)
* Spara din data till n�gon sorts fil ist�llet f�r att bara jobba mot en lista
* Se till att update fortfarande funkar