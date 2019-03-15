using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using DotNet.DAL.Interfaces;
using DotNet.DAL.Entities;
using AutoMapper;

namespace DotNet.BLL.Services
{
    public class BookService : IBookService
    {
        private IRepository<Book> bookRepository;


        public BookService(IRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }



        public void Create(BookModel book)
        {
	        var model = Mapper.Map<Book>(book);
            bookRepository.Create(model);
        }

        public void Delete(BookModel book)
        {
	        bookRepository.Delete(b => b.Id == book.Id);
		}

        public IEnumerable<BookModel> Find(BookModel book)
        {
			var result = bookRepository.Find(b => b.Id == book.Id);
	        return Mapper.Map<IEnumerable<BookModel>>(result);
        }

        public BookModel Get(int id)
        {
            var result = bookRepository.Get(model => model.Id == id);
            return Mapper.Map<BookModel>(result);
        }

        public IEnumerable<BookModel> GetAll()
        {
            var result = bookRepository.GetAll();
            return Mapper.Map<IEnumerable<BookModel>>(result);
        }

        public void Update(BookModel book)
        {
	        var model = Mapper.Map<Book>(book);
			bookRepository.Update(b => b.Id == book.Id, model);
		}
    }
}
