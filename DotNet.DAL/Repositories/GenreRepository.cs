using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class GenreRepository : IRepository<Genre>
	{
		private readonly IDBContext _context;

		public GenreRepository(IDBContext dbContext)
		{
			_context = dbContext;
		}


		public IEnumerable<Genre> GetAll()
		{
			return _context.Genres.Find(_ => true).ToList();
		}

		public Genre Get(string id)
		{
			return _context.Genres.Find(x => x.Id == ObjectId.Parse(id)).FirstOrDefault();
		}

		public void Add(Genre item)
		{
			_context.Genres.InsertOne(item);
		}

		public void Remove(string id)
		{
			_context.Genres.DeleteOne(Builders<Genre>.Filter.Eq(x => x.Id, ObjectId.Parse(id)));
		}

		public void Update(Genre item)
		{
			_context.Genres.ReplaceOne(x => x.Id == item.Id, item, new UpdateOptions { IsUpsert = true });
		}
	}
}
