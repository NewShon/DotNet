using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class GenreRepository : IRepository<Genre>
	{
		private readonly MongoDBContext _context;

		public GenreRepository(MongoDBContext mongoDbContext)
		{
			_context = mongoDbContext;
		}


		public IEnumerable<Genre> GetAll()
		{
			return _context.Genres.Find(_ => true).ToList();
		}

		public Genre Get(string id)
		{
			return _context.Genres.Find(x => x.GenreId == id).FirstOrDefault();
		}

		public void Add(Genre item)
		{
			_context.Genres.InsertOne(item);
		}

		public void Remove(Genre item)
		{
			_context.Genres.DeleteOne(Builders<Genre>.Filter.Eq(x => x.GenreId, item.GenreId));
		}

		public void Update(Genre item)
		{
			_context.Genres.ReplaceOne(x => x.GenreId == item.GenreId, item, new UpdateOptions { IsUpsert = true });
		}
	}
}
