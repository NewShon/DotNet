using System;
using System.Collections.Generic;
using System.Linq;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.DAL.Repositories
{
	public class AuthorRepository : IRepository<Author>
	{
		public void Create(Author author)
		{
			Warehouse.Authors.Add(author);
		}

		public void Delete(Func<Author, bool> predicate)
		{
			var authorsForDelete = Warehouse.Authors.Where(predicate);
			foreach (var author in authorsForDelete)
			{
				Warehouse.Authors.Remove(author);
			}
		}

		public IEnumerable<Author> Find(Func<Author, bool> predicate)
		{
			return Warehouse.Authors.Where(predicate);
		}

		public Author Get(Func<Author, bool> predicate)
		{
			return Warehouse.Authors.Where(predicate).FirstOrDefault();
		}

		public IEnumerable<Author> GetAll()
		{
			return Warehouse.Authors;
		}

		public void Update(Func<Author, bool> predicate, Author author)
		{
			var authorsForUpdate = Warehouse.Authors.Where(predicate).FirstOrDefault();
			if (authorsForUpdate != null)
			{
				authorsForUpdate.Name = author.Name;
				authorsForUpdate.Books = author.Books;
			}
		}
	}
}
