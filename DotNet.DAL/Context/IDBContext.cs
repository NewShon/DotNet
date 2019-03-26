using System;
using System.Collections.Generic;
using System.Text;
using DotNet.DAL.Entities;
using MongoDB.Driver;

namespace DotNet.DAL.Context
{
    public interface IDBContext
    {
	    IMongoCollection<Book> Books { get; }
	    IMongoCollection<Genre> Genres { get; }
		IMongoCollection<Author> Authors { get; }
	}
}
