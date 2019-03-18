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


	    public void Add(GenreModel item)
	    {
		    var model = Mapper.Map<Genre>(item);
		    genreRepository.Add(model);
	    }

	    public void Remove(GenreModel item)
	    {
		    var model = Mapper.Map<Genre>(item);
		    genreRepository.Remove(model);
	    }

	    public GenreModel Get(GenreModel item)
	    {
		    var model = Mapper.Map<Genre>(item);
		    var result = genreRepository.Get(model);
		    return Mapper.Map<GenreModel>(result);
	    }

	    public IEnumerable<GenreModel> GetAll()
	    {
		    var result = genreRepository.GetAll();
		    return Mapper.Map<IEnumerable<GenreModel>>(result);
	    }

	    public void Update(GenreModel item)
	    {
		    var model = Mapper.Map<Genre>(item);
		    genreRepository.Update(model);
	    }
	}
}
