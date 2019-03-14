using System;
using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using DotNet.DAL.Interfaces;
using DotNet.DAL.Entities;

namespace DotNet.BLL.Services
{
    public class BookService : IService<BookModel>
    {
        private IRepository<Book> bookRepository;


        public BookService(IRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }



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

        public BookModel Get(int id)
        {
            var result = bookRepository.Get(model => model.Id == id);
            return AutoMapper.Mapper.Map<BookModel>(result);
        }

        public IEnumerable<BookModel> GetAll()
        {
            var result = bookRepository.GetAll();
            return AutoMapper.Mapper.Map<List<BookModel>>(result);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
