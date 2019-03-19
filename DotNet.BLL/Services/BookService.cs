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


	    public void Add(BookModel item)
	    {
            item.Id = null;
            var model = Mapper.Map<Book>(item);
		    bookRepository.Add(model);
	    }

        public void Remove(string id)
        {
            bookRepository.Remove(id);
        }

        public BookModel Get(string id)
	    {
		    var result = bookRepository.Get(id);
		    return Mapper.Map<BookModel>(result);
	    }

	    public IEnumerable<BookModel> GetAll()
	    {
		    var result = bookRepository.GetAll();
		    return Mapper.Map<IEnumerable<BookModel>>(result);
	    }

	    public void Update(BookModel item)
	    {
		    var model = Mapper.Map<Book>(item);
		    bookRepository.Update(model);
	    }
	}
}
