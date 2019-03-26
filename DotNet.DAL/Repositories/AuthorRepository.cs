using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class AuthorRepository : IRepository<Author>
	{
		private readonly IDBContext _context;

		public AuthorRepository(IDBContext dbContext)
		{
			_context = dbContext;
		}


		public IEnumerable<Author> GetAll()
		{
			return _context.Authors.Find(_ => true).ToList();
		}

		public Author Get(string id)
		{
			return _context.Authors.Find(x => x.Id == ObjectId.Parse(id)).FirstOrDefault();
		}

		public void Add(Author item)
		{
			_context.Authors.InsertOne(item);
		}

		public void Remove(string id)
		{
			_context.Authors.DeleteOne(Builders<Author>.Filter.Eq(x => x.Id, ObjectId.Parse(id)));
		}

		public void Update(Author item)
		{
			_context.Authors.ReplaceOne(x => x.Id == item.Id, item, new UpdateOptions { IsUpsert = true });

		}
	}
}
