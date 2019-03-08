using System;
using DotNet.BLL.Interfaces;
using DotNet.DAL.Entities;
using System.Collections.Generic;

namespace DotNet.BLL.Services
{
    public class BookService : IBookService<BookModel>
    {
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
            throw new NotImplementedException();
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
