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



	    public void Create(AuthorModel author)
	    {
		    var model = Mapper.Map<Author>(author);
		    authorRepository.Create(model);
	    }

	    public void Delete(AuthorModel author)
	    {
		    authorRepository.Delete(x => x.Id == author.Id);
	    }

	    public IEnumerable<AuthorModel> Find(AuthorModel author)
	    {
		    var result = authorRepository.Find(x => x.Id == author.Id);
		    return Mapper.Map<IEnumerable<AuthorModel>>(result);
	    }

	    public AuthorModel Get(int id)
	    {
		    var result = authorRepository.Get(x => x.Id == id);
		    return Mapper.Map<AuthorModel>(result);
	    }

	    public IEnumerable<AuthorModel> GetAll()
	    {
		    var result = authorRepository.GetAll();
		    return Mapper.Map<IEnumerable<AuthorModel>>(result);
	    }

	    public void Update(AuthorModel author)
	    {
		    var model = Mapper.Map<Author>(author);
		    authorRepository.Update(x => x.Id == author.Id, model);
	    }
	}
}
