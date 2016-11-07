# Labb 9 - TicTacToe
## Uppgifter
Ni ska bygga ett TicTacToe-spel (tre i rad)
* Programmet ska hela tiden visa spelbr�dan
* Man ska kunna vara tv� spelare p� samma dator
* Spelarna ska turas om att s�tta ut sin mark�r
* N�r spelbr�dan �r full ska eventet GameOver h�jas
	* GameOver ska skriva ut ett meddelande och avsluta rundan

### Klasser och metoder
H�r �r en lista p� n�gra saker jag vill se i era program, ni f�r g�rna l�gga till fler saker om ni k�nner att det beh�vs eller �ndra om ni har b�ttre id�er!
* Skapa en Node-klass som representerar varje ruta p� br�dan
	* Properties:
		* Taken: bool
		* Player: int
* Skapa en klass f�r spelbr�dan och implementera ett interface enligt f�ljande:
	* Properties:
		* Grid: Node[] (alternativt Node[,] Googla "C# 2D array")
	* Metoder:
		* PlaceMarker(int row, int col, int player)

## Extrauppgift
* Om n�gon av spelarna f�r tre i rad ska GameOver eventet h�jas med ett meddelande som ber�ttar vem som vann