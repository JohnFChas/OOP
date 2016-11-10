# Labb 9 - TicTacToe
## Uppgifter
Ni ska bygga ett TicTacToe-spel (tre i rad)
* Programmet ska hela tiden visa spelbrädan
* Man ska kunna vara två spelare på samma dator
* Spelarna ska turas om att sätta ut sin markör
* När spelbrädan är full ska eventet GameOver höjas
	* GameOver ska skriva ut ett meddelande och avsluta rundan

### Klasser och metoder
Här är en lista på några saker jag vill se i era program, ni får gärna lägga till fler saker om ni känner att det behövs eller ändra om ni har bättre idéer!
* Skapa en Node-klass som representerar varje ruta på brädan
	* Properties:
		* Taken: bool
		* Player: int
* Skapa en klass för spelbrädan och implementera ett interface enligt följande:
	* Properties:
		* Grid: Node\[\] (alternativt Node[,] Googla "C# 2D array")
	* Metoder:
		* PlaceMarker(int row, int col, int player)

## Extrauppgift
* Om någon av spelarna får tre i rad ska GameOver eventet höjas med ett meddelande som berättar vem som vann
