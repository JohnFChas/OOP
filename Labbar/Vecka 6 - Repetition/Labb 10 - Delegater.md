# Labb 10 - Delegater
## Uppgifter
* Skapa följande klasser med properties och metoder:
	1. Book
		* Title: string
		* Pages: int
		* Genre: string (eller enum)
		* Price: double
	2. BookManager
		* Books: List<Book>
		* PrintWhere(BookFilter filter)
* Skapa följande delegat: bool BookFilter(Book book)
* Skapa följande metoder för delegaten BookFilter:
	* IsNovel
	* IsShortStory
	* IsGenreMystery
	* IsGenreFantasy
	* IsGenreRomance
	* IsCheap
	* IsExpensive
* Använd dessa filter för att låta programmet skriva ut böcker som matcher filtrens villkor