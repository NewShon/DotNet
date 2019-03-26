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
            item.Id = null;
            var model = Mapper.Map<Genre>(item);
		    genreRepository.Add(model);
	    }

        public void Remove(string id)
        {
            genreRepository.Remove(id);
        }

        public GenreModel Get(string id)
	    {
		    var result = genreRepository.Get(id);
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
