using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using DotNet.WEB.Models;
using System.Collections.Generic;
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
        public IEnumerable<BookViewModel> Get()
        {
            var result = bookService.GetAll();
            return Mapper.Map<List<BookViewModel>>(result);
        }

        // GET: api/Book/5
        public BookViewModel Get(int id)
        {
            var result = bookService.Get(id);
            return Mapper.Map<BookViewModel>(result);
        }

        // POST: api/Book
        public void Post(BookViewModel book)
        {
	        var model = Mapper.Map<BookModel>(book);
			bookService.Create(model);
        }

        // PUT: api/Book/5
        public void Put(BookViewModel book)
        {
	        var model = Mapper.Map<BookModel>(book);
			bookService.Update(model);
        }

        // DELETE: api/Book/5
        public void Delete(BookViewModel book)
        {
	        var model = Mapper.Map<BookModel>(book);
			bookService.Delete(model);
        }
    }
}
