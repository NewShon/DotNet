using System;
using System.Collections.Generic;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.DAL.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private List<Book> books = new List<Book>
        {
            new Book{ Name = "Anarchy of decay" },
            new Book { Name = "Illusion of freedom" },
            new Book { Name = "Legendary moonlight sculptor" }
        };


        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> Find(Func<Book, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            return books[id];
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
