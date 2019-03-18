using System;
using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class BookRepository : IRepository<Book>
	{
		private readonly DBContext _context;

		public BookRepository()
		{
			_context = new DBContext();
		}


		public IEnumerable<Book> GetAll()
		{
			try
			{
				return _context.Books.Find(_ => true).ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Book Get(string id)
		{
			try
			{
				return _context.Books.Find(x => x.BookId == id).FirstOrDefault();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Add(Book item)
		{
			try
			{
				_context.Books.InsertOne(item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Remove(Book item)
		{
			try
			{
				_context.Books.DeleteOne(Builders<Book>.Filter.Eq(x => x.BookId, item.BookId));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Update(Book item)
		{
			try
			{
				_context.Books.ReplaceOne(x => x.BookId == item.BookId, item, new UpdateOptions { IsUpsert = true });
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
