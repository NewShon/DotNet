using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class BookRepository : IRepository<Book>
	{
		private readonly MongoDBContext _context;

		public BookRepository(MongoDBContext mongoDbContext)
		{
			_context = mongoDbContext;
		}


		public IEnumerable<Book> GetAll()
		{
			return _context.Books.Find(_ => true).ToList();
		}

		public Book Get(string id)
		{
			return _context.Books.Find(x => x.BookId == id).FirstOrDefault();
		}

		public void Add(Book item)
		{
			_context.Books.InsertOne(item);
		}

		public void Remove(Book item)
		{
			_context.Books.DeleteOne(Builders<Book>.Filter.Eq(x => x.BookId, item.BookId));
		}

		public void Update(Book item)
		{
			_context.Books.ReplaceOne(x => x.BookId == item.BookId, item, new UpdateOptions { IsUpsert = true });
		}
	}
}
