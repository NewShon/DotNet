using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using DotNet.WEB.Models;

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
	    public IEnumerable<GenreViewModel> Get()
	    {
		    var result = genreService.GetAll();
		    return Mapper.Map<List<GenreViewModel>>(result);
	    }

		// GET: api/Genre/5
		public GenreViewModel Get(int id)
	    {
		    var result = genreService.Get(id);
		    return Mapper.Map<GenreViewModel>(result);
	    }

		// POST: api/Genre
		public void Post(GenreViewModel genre)
	    {
		    var model = Mapper.Map<GenreModel>(genre);
		    genreService.Create(model);
	    }

		// PUT: api/Genre/5
		public void Put(GenreViewModel genre)
	    {
		    var model = Mapper.Map<GenreModel>(genre);
		    genreService.Update(model);
	    }

		// DELETE: api/Genre/5
		public void Delete(GenreViewModel genre)
	    {
		    var model = Mapper.Map<GenreModel>(genre);
		    genreService.Delete(model);
	    }
	}
}
