using DotNet.DAL.Entities;
using System.Collections.Generic;

namespace DotNet.DAL.Repositories
{
    public static class Warehouse
    {
        public static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Name = "Anarchy of decay", Description = "Good book 1" },
            new Book { Id = 2, Name = "Illusion of freedom", Description = "Good book 2"  },
            new Book { Id = 3, Name = "Legendary moonlight sculptor", Description = "Good book 3"  }
        };

        public static List<Genre> Genres = new List<Genre>
        {
            new Genre { Id = 1, Name = "Apocalypse", Books = { Books[0] } },
            new Genre { Id = 2, Name = "Philosophy", Books = { Books[1] } },
            new Genre { Id = 3, Name = "RPG", Books = { Books[2] } }
        };

        public static List<Author> Authors = new List<Author>
        {
            new Author { Id = 1, Name = "Michael", Books = { Books[0], Books[2] } },
            new Author { Id = 2, Name = "Raichel", Books = { Books[1] } }
        };
    }
}
