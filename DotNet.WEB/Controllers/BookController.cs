using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using DotNet.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNet.WEB.Controllers
{
    public class BookController : ApiController
    {
        private IBookService<BookModel> bookService;


        public BookController(IBookService<BookModel> bookService)
        {
            this.bookService = bookService;
        }



        // GET: api/Book
        public IEnumerable<BookViewModel> Get()
        {
            var result = bookService.GetAll();
            return AutoMapper.Mapper.Map<List<BookViewModel>>(result);
        }

        // GET: api/Book/5
        public BookViewModel Get(int id)
        {
            var result = bookService.Get(id);
            return AutoMapper.Mapper.Map<BookViewModel>(result);
        }

        // POST: api/Book
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
        }
    }
}
