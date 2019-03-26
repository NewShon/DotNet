using DotNet.DAL.Entities;
using MongoDB.Driver;

namespace DotNet.DAL.Context
{
	public interface IDBContext
	{
		IMongoCollection<Book> Books { get; set; }
		IMongoCollection<Genre> Genres { get; set; }
		IMongoCollection<Author> Authors { get; set; }
	}
}
