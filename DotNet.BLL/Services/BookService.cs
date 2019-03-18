﻿using DotNet.BLL.Interfaces;
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
		    var model = Mapper.Map<Book>(item);
		    bookRepository.Add(model);
	    }

	    public void Remove(BookModel item)
	    {
		    var model = Mapper.Map<Book>(item);
		    bookRepository.Remove(model);
	    }

	    public BookModel Get(BookModel item)
	    {
		    var model = Mapper.Map<Book>(item);
		    var result = bookRepository.Get(model);
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
