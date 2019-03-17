using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DotNet.DAL.Entities
{
    public class Book
    {
        [BsonId]
        public ObjectId InternalId { get; set; }

        [BsonElement("BookId")]
        public int BookId { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Authors")]
        public ICollection<Author> Authors{ get; set; }

        [BsonElement("Genres")]
        public ICollection<Genre> Genres { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }
    }
}
