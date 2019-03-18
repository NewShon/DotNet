using System.Collections.Generic;
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
		public IEnumerable<AuthorViewModel> Get()
		{
			var result = authorService.GetAll();
			return Mapper.Map<List<AuthorViewModel>>(result);
		}

		// GET: api/Author/5
		public AuthorViewModel Get(string id)
		{
			var result = authorService.Get(id);
			return Mapper.Map<AuthorViewModel>(result);
		}

		// POST: api/Author
		public void Post(AuthorViewModel item)
		{
			var model = Mapper.Map<AuthorModel>(item);
			authorService.Add(model);
		}

		// PUT: api/Author/5
		public void Put(AuthorViewModel author)
		{
			var model = Mapper.Map<AuthorModel>(author);
			authorService.Update(model);
		}

		// DELETE: api/Author/5
		public void Delete(AuthorViewModel author)
		{
			var model = Mapper.Map<AuthorModel>(author);
			authorService.Remove(model);
		}
	}
}
