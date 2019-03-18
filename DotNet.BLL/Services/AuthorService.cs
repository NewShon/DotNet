using DotNet.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;
using DotNet.BLL.Models;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.BLL.Services
{
	public class AuthorService : IAuthorService
	{
		private IRepository<Author> authorRepository;

		public AuthorService(IRepository<Author> authorRepository)
		{
			this.authorRepository = authorRepository;
		}


		public void Add(AuthorModel item)
		{
			var model = Mapper.Map<Author>(item);
			authorRepository.Add(model);
		}

		public void Remove(AuthorModel item)
		{
			var model = Mapper.Map<Author>(item);
			authorRepository.Remove(model);
		}

		public AuthorModel Get(string id)
		{
			var result = authorRepository.Get(id);
			return Mapper.Map<AuthorModel>(result);
		}

		public IEnumerable<AuthorModel> GetAll()
		{
			var result = authorRepository.GetAll();
			return Mapper.Map<IEnumerable<AuthorModel>>(result);
		}

		public void Update(AuthorModel item)
		{
			var model = Mapper.Map<Author>(item);
			authorRepository.Update(model);
		}
	}
}
