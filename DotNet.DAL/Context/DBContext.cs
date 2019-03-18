using DotNet.DAL.Entities;
using MongoDB.Driver;
using System.Configuration;
using System.Security.Authentication;

namespace DotNet.DAL.Context
{
    public class DBContext
    {
        private readonly IMongoDatabase _database;

        public DBContext()
        {
			// Azure
	        MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConfigurationManager.AppSettings["AzureServer"]));
	        settings.SslSettings = new SslSettings { EnabledSslProtocols = SslProtocols.Tls12 };
	        var mongoClient = new MongoClient(settings);
	        _database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["AzureDatabase"]);
			

			// Local
			//var client = new MongoClient(ConfigurationManager.AppSettings["Server"]);
			//_database = client.GetDatabase(ConfigurationManager.AppSettings["Database"]);
		}

		public IMongoCollection<Book> Books => _database.GetCollection<Book>("Books");

		public IMongoCollection<Genre> Genres => _database.GetCollection<Genre>("Genres");

		public IMongoCollection<Author> Authors => _database.GetCollection<Author>("Authors");
    }
}
