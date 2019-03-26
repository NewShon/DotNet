using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using DotNet.WEB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace DotNet.WEB.Controllers
{
	public class BookController : ApiController
	{
		private IBookService bookService;

		public BookController(IBookService bookService)
		{
			this.bookService = bookService;
		}


		// GET: api/Book
		public HttpResponseMessage Get()
		{
			var result = bookService.GetAll();
			if (!result.Any())
			{
				return new HttpResponseMessage(HttpStatusCode.BadRequest);
			}
			return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<List<BookViewModel>>(result));
		}

		// GET: api/Book/5
		public BookViewModel Get(string id)
		{
			var result = bookService.Get(id);
			return Mapper.Map<BookViewModel>(result);
		}

		// POST: api/Book
		public void Post(BookViewModel book)
		{
			var model = Mapper.Map<BookModel>(book);
			bookService.Add(model);
		}

		// PUT: api/Book/5
		public void Put(BookViewModel item)
		{
			var model = Mapper.Map<BookModel>(item);
			bookService.Update(model);
		}

		// DELETE: api/Book/5
		public void Delete(string id)
		{
			bookService.Remove(id);
		}
	}
}
