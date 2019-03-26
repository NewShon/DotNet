using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class BookRepository : IRepository<Book>
	{
		private readonly IDBContext _context;

		public BookRepository(IDBContext dbContext)
		{
			_context =dbContext;
		}


		public IEnumerable<Book> GetAll()
		{
			return _context.Books.Find(_ => true).ToList();
		}

		public Book Get(string id)
		{
			return _context.Books.Find(x => x.Id == ObjectId.Parse(id)).FirstOrDefault();
		}

		public void Add(Book item)
		{
			_context.Books.InsertOne(item);
		}

		public void Remove(string id)
		{
			_context.Books.DeleteOne(Builders<Book>.Filter.Eq(x => x.Id, ObjectId.Parse(id)));
		}

		public void Update(Book item)
		{
			_context.Books.ReplaceOne(x => x.Id == item.Id, item, new UpdateOptions { IsUpsert = true });
		}
	}
}
