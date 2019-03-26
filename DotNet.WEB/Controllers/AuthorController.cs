using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using DotNet.WEB.Models;

namespace DotNet.WEB.Controllers
{
	public class AuthorController : ApiController
	{
		private IAuthorService authorService;

		public AuthorController(IAuthorService authorService)
		{
			this.authorService = authorService;
		}


		// GET: api/Author
		public HttpResponseMessage Get()
		{
            var result = authorService.GetAll();
            if (!result.Any())
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<List<BookViewModel>>(result));
        }

		// GET: api/Author/5
		public HttpResponseMessage Get(string id)
		{
            var result = authorService.Get(id);
            if (result == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<BookViewModel>(result));
        }

		// POST: api/Author
		public HttpResponseMessage Post(AuthorViewModel item)
		{
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<AuthorModel>(item);
                authorService.Add(model);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // PUT: api/Author/5
        public HttpResponseMessage Put(AuthorViewModel author)
		{
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<AuthorModel>(author);
                authorService.Update(model);
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // DELETE: api/Author/5
        public HttpResponseMessage Delete(string id)
		{
			authorService.Remove(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
