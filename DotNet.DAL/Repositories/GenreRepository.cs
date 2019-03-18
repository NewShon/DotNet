using System;
using System.Collections.Generic;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
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

		public Genre Get(Genre item)
		{
			try
			{
				return _context.Genres.Find(x => x.GenreId == item.GenreId).FirstOrDefault();
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

		public void Remove(Genre item)
		{
			try
			{
				_context.Genres.DeleteOne(Builders<Genre>.Filter.Eq(x => x.GenreId, item.GenreId));
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
				_context.Genres.ReplaceOne(x => x.GenreId == item.GenreId, item, new UpdateOptions { IsUpsert = true });
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
