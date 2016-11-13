# Labb 10 - Delegater
## Uppgifter
* Skapa f�ljande klasser med properties och metoder:
	1. Book
		* Title: string
		* Pages: int
		* Genre: string (eller enum)
		* Price: double
	2. BookManager
		* Books: List<Book>
		* PrintWhere(BookFilter filter)
* Skapa f�ljande delegat: bool BookFilter(Book book)
* Skapa f�ljande metoder f�r delegaten BookFilter:
	* IsNovel
	* IsShortStory
	* IsGenreMystery
	* IsGenreFantasy
	* IsGenreRomance
	* IsCheap
	* IsExpensive
* Anv�nd dessa filter f�r att l�ta programmet skriva ut b�cker som matcher filtrens villkor