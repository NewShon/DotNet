using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class AuthorRepository : IRepository<Author>
	{
		private readonly MongoDBContext _context;

		public AuthorRepository(MongoDBContext mongoDbContext)
		{
			_context = mongoDbContext;
		}


		public IEnumerable<Author> GetAll()
		{
			return _context.Authors.Find(_ => true).ToList();
		}

		public Author Get(string id)
		{
			return _context.Authors.Find(x => x.AuthorId == id).FirstOrDefault();
		}

		public void Add(Author item)
		{
			_context.Authors.InsertOne(item);
		}

		public void Remove(Author item)
		{
			_context.Authors.DeleteOne(Builders<Author>.Filter.Eq(x => x.AuthorId, item.AuthorId));
		}

		public void Update(Author item)
		{
			_context.Authors.ReplaceOne(x => x.AuthorId == item.AuthorId, item, new UpdateOptions { IsUpsert = true });

		}
	}
}
