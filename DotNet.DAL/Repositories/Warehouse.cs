using DotNet.DAL.Entities;
using System.Collections.Generic;

namespace DotNet.DAL.Repositories
{
    public static class Warehouse
    {
        public static List<Book> Books;

        public static List<Genre> Genres;

        public static List<Author> Authors;


        static Warehouse()
        {
            Books = new List<Book>
            {
                new Book { Id = 1, Name = "Anarchy of decay", Description = "Good book 1" },
                new Book { Id = 2, Name = "Illusion of freedom", Description = "Good book 2" },
                new Book { Id = 3, Name = "Legendary moonlight sculptor", Description = "Good book 3" }
            };

            Genres = new List<Genre>
            {
                new Genre { Id = 1, Name = "Apocalypse" },
                new Genre { Id = 2, Name = "Philosophy" },
                new Genre { Id = 3, Name = "RPG" }
            };

            Authors = new List<Author>
            {
                new Author { Id = 1, Name = "Michael" },
                new Author { Id = 2, Name = "Raichel" }
            };
        }
    }
}
