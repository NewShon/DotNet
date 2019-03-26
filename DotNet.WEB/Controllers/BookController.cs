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
				return new HttpResponseMessage(HttpStatusCode.NoContent);
			}
			return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<List<BookViewModel>>(result));
		}

		// GET: api/Book/5
		public HttpResponseMessage Get(string id)
		{
			var result = bookService.Get(id);
            if (result == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<BookViewModel>(result));
		}

		// POST: api/Book
		public HttpResponseMessage Post(BookViewModel book)
		{
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<BookModel>(book);
                bookService.Add(model);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // PUT: api/Book/5
        public HttpResponseMessage Put(BookViewModel item)
		{
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<BookModel>(item);
                bookService.Update(model);
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // DELETE: api/Book/5
        public HttpResponseMessage Delete(string id)
		{
			bookService.Remove(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
