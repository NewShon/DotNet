﻿using System;
using DotNet.BLL.Interfaces;
using DotNet.DAL.Entities;
using System.Collections.Generic;

namespace DotNet.BLL.Services
{
    public class GenreService : IGenreService<GenreModel>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreModel> Find(Func<GenreModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public GenreModel Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
