using DotNet.DAL.Entities;
using MongoDB.Driver;
using System.Configuration;
using System.Security.Authentication;

namespace DotNet.DAL.Context
{
	public class MongoDBContext : IDBContext
	{
		private readonly IMongoDatabase _database;

		public MongoDBContext()
		{
#if DEBUG
			// Local
			var client = new MongoClient(ConfigurationManager.AppSettings["LocalServer"]);
			_database = client.GetDatabase(ConfigurationManager.AppSettings["LocalDatabase"]);
#elif (!DEBUG)
			// Azure
			MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConfigurationManager.AppSettings["AzureServer"]));
			settings.SslSettings = new SslSettings { EnabledSslProtocols = SslProtocols.Tls12 };
			var mongoClient = new MongoClient(settings);
			_database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["AzureDatabase"]);
#endif
		}


		public IMongoCollection<Book> Books => _database.GetCollection<Book>("Books");

		public IMongoCollection<Genre> Genres => _database.GetCollection<Genre>("Genres");

		public IMongoCollection<Author> Authors => _database.GetCollection<Author>("Authors");
	}
}
