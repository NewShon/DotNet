using System;
using DotNet.BLL.Interfaces;
using System.Collections.Generic;
using DotNet.BLL.Models;

namespace DotNet.BLL.Services
{
    public class AuthorService : IService<AuthorModel>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorModel> Find(Func<AuthorModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public AuthorModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
