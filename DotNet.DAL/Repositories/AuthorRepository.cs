using System;
using System.Collections.Generic;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.DAL.Repositories
{
    public class AuthorRepository : IRepository<Author>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> Find(Func<Author, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Author Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
