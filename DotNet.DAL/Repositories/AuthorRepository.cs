using System;
using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using MongoDB.Driver;

namespace DotNet.DAL.Repositories
{
	public class AuthorRepository : IRepository<Author>
	{
		private readonly DBContext _context;

		public AuthorRepository()
		{
			_context = new DBContext();
		}


		public IEnumerable<Author> GetAll()
		{
			try
			{
				return _context.Authors.Find(_ => true).ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Author Get(string id)
		{
			try
			{
				return _context.Authors.Find(x => x.AuthorId == id).FirstOrDefault();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Add(Author item)
		{
			try
			{
				_context.Authors.InsertOne(item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Remove(Author item)
		{
			try
			{
				_context.Authors.DeleteOne(Builders<Author>.Filter.Eq(x => x.AuthorId, item.AuthorId));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Update(Author item)
		{
			try
			{
				_context.Authors.ReplaceOne(x => x.AuthorId == item.AuthorId, item, new UpdateOptions { IsUpsert = true });
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
