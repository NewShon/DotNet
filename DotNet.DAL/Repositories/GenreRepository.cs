using System;
using System.Collections.Generic;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.DAL.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> Find(Func<Genre, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Genre Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
