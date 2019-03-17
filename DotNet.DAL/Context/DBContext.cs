using DotNet.DAL.Entities;
using MongoDB.Driver;
using System.Configuration;

namespace DotNet.DAL.Context
{
    public class DBContext
    {
        private readonly IMongoDatabase _database;

        public DBContext()
        {
            var client = new MongoClient(ConfigurationManager.AppSettings["Server"]);
            if (client != null)
            {
                _database = client.GetDatabase(ConfigurationManager.AppSettings["Database"]);
            }
        }

        public IMongoCollection<Book> Books
        {
            get
            {
                return _database.GetCollection<Book>("Books");
            }
        }
    }
}
