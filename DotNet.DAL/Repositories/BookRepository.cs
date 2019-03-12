﻿using System;
using System.Collections.Generic;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.DAL.Repositories
{
    public class BookRepository : IRepository<Book>
    {
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
            return Warehouse.Books[id];
        }

        public IEnumerable<Book> GetAll()
        {
            return Warehouse.Books;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
