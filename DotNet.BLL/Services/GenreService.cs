using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using AutoMapper;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.BLL.Services
{
    public class GenreService : IGenreService
    {
		private IRepository<Genre> genreRepository;


	    public GenreService(IRepository<Genre> genreRepository)
	    {
		    this.genreRepository = genreRepository;
	    }



	    public void Create(GenreModel genre)
	    {
		    var model = Mapper.Map<Genre>(genre);
		    genreRepository.Create(model);
	    }

	    public void Delete(GenreModel genre)
	    {
		    genreRepository.Delete(x => x.Id == genre.Id);
	    }

	    public IEnumerable<GenreModel> Find(GenreModel genre)
	    {
		    var result = genreRepository.Find(x => x.Id == genre.Id);
		    return Mapper.Map<IEnumerable<GenreModel>>(result);
	    }

	    public GenreModel Get(int id)
	    {
		    var result = genreRepository.Get(x => x.Id == id);
		    return Mapper.Map<GenreModel>(result);
	    }

	    public IEnumerable<GenreModel> GetAll()
	    {
		    var result = genreRepository.GetAll();
		    return Mapper.Map<IEnumerable<GenreModel>>(result);
	    }

	    public void Update(GenreModel genre)
	    {
		    var model = Mapper.Map<Genre>(genre);
		    genreRepository.Update(x => x.Id == genre.Id, model);
	    }
	}
}
