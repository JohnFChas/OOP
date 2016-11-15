# Labb 15 - Interface
## Uppgifter
* Skapa interfacet IProductRepository med följande metoder:
	* Add()
	* Get(int id)
	* GetAll()
	* Update(Product updatedProduct)
	* Delete(int id)
* Skapa klasserna ListProductRepository och FileProductRepository och låt dem implementera IProductRepository
* Låt ListProductRepository spara och hämta data från en privat lista
* Låt FileProductRepository spara och hämta data från en fil, se JSON-workshoppen för ett exempel på hur man kan hantera serialisering och avserialisering av text i filer
* Skapa två instanser av IProductRepository, en för ListProductRepository och en för FileProductRepository
* Anropa metoderna i båda och se hur två objekt som implementerar samma methoder implementerar olika lösningar