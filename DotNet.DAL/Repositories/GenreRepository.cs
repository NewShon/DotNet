using System;
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
		private readonly DBContext _context;

		public GenreRepository()
		{
			_context = new DBContext();
		}


		public IEnumerable<Genre> GetAll()
		{
			try
			{
				return _context.Genres.Find(_ => true).ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Genre Get(string id)
		{
			try
			{
				return _context.Genres.Find(x => x.Id == ObjectId.Parse(id)).FirstOrDefault();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Add(Genre item)
		{
			try
			{
				_context.Genres.InsertOne(item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Remove(string id)
		{
			try
			{
				_context.Genres.DeleteOne(Builders<Genre>.Filter.Eq(x => x.Id, ObjectId.Parse(id)));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Update(Genre item)
		{
			try
			{
				_context.Genres.ReplaceOne(x => x.Id == item.Id, item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
