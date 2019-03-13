using System;
using System.Collections.Generic;
using System.Linq;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.DAL.Repositories
{
	public class GenreRepository : IRepository<Genre>
	{
		public void Create(Genre genre)
		{
			Warehouse.Genres.Add(genre);
		}

		public void Delete(Func<Genre, bool> predicate)
		{
			var booksForDelete = Warehouse.Genres.Where(predicate);
			foreach (var genre in booksForDelete)
			{
				Warehouse.Genres.Remove(genre);
			}
		}

		public IEnumerable<Genre> Find(Func<Genre, bool> predicate)
		{
			return Warehouse.Genres.Where(predicate);
		}

		public Genre Get(Func<Genre, bool> predicate)
		{
			return Warehouse.Genres.Where(predicate).FirstOrDefault();
		}

		public IEnumerable<Genre> GetAll()
		{
			return Warehouse.Genres;
		}

		public void Update(Func<Genre, bool> predicate, Genre genre)
		{
			var genreForUpdate = Warehouse.Genres.Where(predicate).FirstOrDefault();
			if (genreForUpdate != null)
			{
				genreForUpdate.Name = genre.Name;
				genreForUpdate.Books = genre.Books;
			}
		}
	}
}
