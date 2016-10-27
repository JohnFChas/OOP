# Labb 6 - Console adventure
Du ska bygga ett text-baserat �ventyr! I ditt �ventyr ska man kunna vandra mellan milj�er, prata och observera saker.
### Del 1
* Skapa interfaces, till exempel:
	* INonPlayerCharacter
		* Ska kunna prata
		* Ska g� att observera (f�r att f� utseende och s�nt)
	* IEnvironment
		* Ska kunna inneh�lla INonPlayerCharacter(s)
		* Ska g� att observera
* Skapa klasser som implementerar dessa interface, till exempel:
	* Human : INonPlayerCharacter
	* Animal: INonPlayerCharacter
	* Room : IEnvironment
	* Yard : IEnvironment

### Del 2
* Skapa ett text-�ventyr d�r man kan vandra mellan olika milj�er och interagera med milj�er och NPC'er

### Del 3
* Det ska finnas en NPC n�gonstans som ger spelaren n�got sorts problem, till exempel en g�ta
* Genom att vandra bland milj�er och interagera med saker och ting ska spelaren kunna lista ut svaret p� problemet