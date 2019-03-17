using DotNet.DAL.Entities;
using System.Collections.Generic;

namespace DotNet.DAL.Repositories
{
	public static class Warehouse
	{
		public static List<Book> Books = new List<Book>
		{
			new Book {BookId = 1, Name = "Anarchy of decay", Description = "Good book 1"},
			new Book {BookId = 2, Name = "Illusion of freedom", Description = "Good book 2"},
			new Book {BookId = 3, Name = "Legendary moonlight sculptor", Description = "Good book 3"}
		};

		public static List<Genre> Genres = new List<Genre>
		{
			new Genre {Id = 1, Name = "Apocalypse", Books = new List<Book> {Books[0]}},
			new Genre {Id = 2, Name = "Philosophy", Books = new List<Book> {Books[1]}},
			new Genre {Id = 3, Name = "RPG", Books = new List<Book> {Books[2]}}
		};

		public static List<Author> Authors = new List<Author>
		{
			new Author {Id = 1, Name = "Michael", Books = new List<Book> {Books[0], Books[2]}},
			new Author {Id = 2, Name = "Raichel", Books = new List<Book> {Books[1]}}
		};

		static Warehouse()
		{
			//Books[0].Authors = new List<Author> { Authors[0] };
			//Books[1].Authors = new List<Author> { Authors[1] };
			//Books[2].Authors = new List<Author> { Authors[0] };

			//Books[0].Genres = new List<Genre> { Genres[0] };
			//Books[1].Genres = new List<Genre> { Genres[1] };
			//Books[2].Genres = new List<Genre> { Genres[2] };
		}
	}
}
