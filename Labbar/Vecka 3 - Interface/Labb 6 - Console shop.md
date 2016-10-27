# Labb 6 - Console adventure
Du ska bygga ett text-baserat äventyr! I ditt äventyr ska man kunna vandra mellan miljöer, prata och observera saker.
### Del 1
* Skapa interfaces, till exempel:
	* INonPlayerCharacter
		* Ska kunna prata
		* Ska gå att observera (för att få utseende och sånt)
	* IEnvironment
		* Ska kunna innehålla INonPlayerCharacter(s)
		* Ska gå att observera
* Skapa klasser som implementerar dessa interface, till exempel:
	* Human : INonPlayerCharacter
	* Animal: INonPlayerCharacter
	* Room : IEnvironment
	* Yard : IEnvironment

### Del 2
* Skapa ett text-äventyr där man kan vandra mellan olika miljöer och interagera med miljöer och NPC'er

### Del 3
* Det ska finnas en NPC någonstans som ger spelaren något sorts problem, till exempel en gåta
* Genom att vandra bland miljöer och interagera med saker och ting ska spelaren kunna lista ut svaret på problemet