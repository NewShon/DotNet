using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DotNet.DAL.Entities
{
    public class Book
    {
        [BsonId]
        public ObjectId InternalId { get; set; }

        [BsonIgnore]
        public string BookId { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Authors")]
        public ICollection<int> Authors{ get; set; }

        [BsonElement("Genres")]
        public ICollection<int> Genres { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }
    }
}
