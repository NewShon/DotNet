using System;
using DotNet.BLL.Interfaces;
using DotNet.DAL.Entities;
using System.Collections.Generic;
using DotNet.BLL.Interfaces.Base;

namespace DotNet.BLL.Services
{
    public class AuthorService : IAuthorService<AuthorModel>
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

        public AuthorModel Get()
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
