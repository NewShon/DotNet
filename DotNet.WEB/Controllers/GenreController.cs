using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using DotNet.WEB.Models;
using System.Net;
using System.Net.Http;
using System.Linq;

namespace DotNet.WEB.Controllers
{
	public class GenreController : ApiController
	{
		private IGenreService genreService;

		public GenreController(IGenreService genreService)
		{
			this.genreService = genreService;
		}


		// GET: api/Genre
		public HttpResponseMessage Get()
		{
            var result = genreService.GetAll();
            if (!result.Any())
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<List<BookViewModel>>(result));
        }

		// GET: api/Genre/5
		public HttpResponseMessage Get(string id)
		{
            var result = genreService.Get(id);
            if (result == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<BookViewModel>(result));
        }

		// POST: api/Genre
		public HttpResponseMessage Post(GenreViewModel item)
		{
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<GenreModel>(item);
                genreService.Add(model);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

		// PUT: api/Genre/5
		public HttpResponseMessage Put(GenreViewModel item)
		{
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<GenreModel>(item);
                genreService.Update(model);
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

		// DELETE: api/Genre/5
		public HttpResponseMessage Delete(string id)
		{
			genreService.Remove(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
	}
}
