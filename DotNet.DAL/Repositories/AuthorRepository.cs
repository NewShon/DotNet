using System;
using System.Collections.Generic;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;

namespace DotNet.DAL.Repositories
{
    public class AuthorRepository : IRepository<Author>
    {
		public void Create(Book book)
	    {
		    Warehouse.Books.Add(book);
	    }

	    public void Delete(Func<Book, bool> predicate)
	    {
		    var booksForDelete = Warehouse.Books.Where(predicate);
		    foreach (var book in booksForDelete)
		    {
			    Warehouse.Books.Remove(book);

		    }
	    }

	    public IEnumerable<Book> Find(Func<Book, bool> predicate)
	    {
		    return Warehouse.Books.Where(predicate);
	    }

	    public Book Get(Func<Book, bool> predicate)
	    {
		    return Warehouse.Books.Where(predicate).FirstOrDefault();
	    }

	    public IEnumerable<Book> GetAll()
	    {
		    return Warehouse.Books;
	    }

	    public void Update(Func<Book, bool> predicate, Book book)
	    {
		    var bookForUpdate = Warehouse.Books.Where(predicate).FirstOrDefault();
		    if (bookForUpdate != null)
		    {
			    bookForUpdate.Name = book.Name;
			    bookForUpdate.Authors = book.Authors;
			    bookForUpdate.Description = book.Description;
			    bookForUpdate.Genres = book.Genres;
		    }
	    }
	}
}
