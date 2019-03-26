using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DotNet.DAL.Entities
{
    public class Book
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Authors")]
        public ICollection<string> Authors{ get; set; }

        [BsonElement("Genres")]
        public ICollection<string> Genres { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }
    }
}
