using System;
using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;

namespace DotNet.BLL.Services
{
    public class BookService : IBookService<BookModel>
    {
        private List<BookModel> books = new List<BookModel>
        {
            new BookModel { Name = "Anarchy of decay" },
            new BookModel { Name = "Illusion of freedom" },
            new BookModel { Name = "Legendary moonlight sculptor" }
        };

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> Find(Func<BookModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public BookModel Get()
        {
            return books[0];
        }

        public IEnumerable<BookModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
