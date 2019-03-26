using DotNet.DAL.Entities;
using MongoDB.Driver;
using System.Configuration;
using System.Security.Authentication;

namespace DotNet.DAL.Context
{
	public class MongoDBContext// : IDBContext
	{
		private readonly IMongoDatabase _database;

		public MongoDBContext(string server, string database)
		{
#if DEBUG
			// Azure
			MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(server));
			settings.SslSettings = new SslSettings { EnabledSslProtocols = SslProtocols.Tls12 };
			var mongoClient = new MongoClient(settings);
			_database = mongoClient.GetDatabase(database);
#elif (!DEBUG)
			// Local
			var client = new MongoClient(server);
			_database = client.GetDatabase(database);
#endif
		}

		public IMongoCollection<Book> Books
		{
			get => _database.GetCollection<Book>("Books");
			set => throw new System.NotImplementedException();
		}

		public IMongoCollection<Genre> Genres
		{
			get => _database.GetCollection<Genre>("Genres");
			set => throw new System.NotImplementedException();
		}

		public IMongoCollection<Author> Authors
		{
			get => _database.GetCollection<Author>("Authors");
			set => throw new System.NotImplementedException();
		}
	}
}
