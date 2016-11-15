# Labb 15 - Interface
## Uppgifter
* Skapa interfacet IProductRepository med f�ljande metoder:
	* Add()
	* Get(int id)
	* GetAll()
	* Update(Product updatedProduct)
	* Delete(int id)
* Skapa klasserna ListProductRepository och FileProductRepository och l�t dem implementera IProductRepository
* L�t ListProductRepository spara och h�mta data fr�n en privat lista
* L�t FileProductRepository spara och h�mta data fr�n en fil, se JSON-workshoppen f�r ett exempel p� hur man kan hantera serialisering och avserialisering av text i filer
* Skapa tv� instanser av IProductRepository, en f�r ListProductRepository och en f�r FileProductRepository
* Anropa metoderna i b�da och se hur tv� objekt som implementerar samma methoder implementerar olika l�sningar