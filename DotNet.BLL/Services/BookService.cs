using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using DotNet.DAL.Interfaces;
using DotNet.DAL.Entities;
using AutoMapper;
using DotNet.DAL.Repositories;

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
            //var model = Mapper.Map<Book>(book);
            //bookRepository.Create(model);
            var db = new NoteRepository();
            db.AddBook(new Book { BookId = 1, Name = "Book number one" });
        }

        public void Delete(BookModel book)
        {
	        bookRepository.Delete(b => b.BookId == book.Id);
		}

        public IEnumerable<BookModel> Find(BookModel book)
        {
			var result = bookRepository.Find(b => b.BookId == book.Id);
	        return Mapper.Map<IEnumerable<BookModel>>(result);
        }

        public BookModel Get(int id)
        {
            var result = bookRepository.Get(model => model.BookId == id);
            return Mapper.Map<BookModel>(result);
        }

        public IEnumerable<BookModel> GetAll()
        {
            //var result = bookRepository.GetAll();
            //return Mapper.Map<IEnumerable<BookModel>>(result);
            var db = new NoteRepository();
            return Mapper.Map<IEnumerable<BookModel>>(db.GetAllBooks());
        }

        public void Update(BookModel book)
        {
	        var model = Mapper.Map<Book>(book);
			bookRepository.Update(b => b.BookId == book.Id, model);
		}
    }
}
