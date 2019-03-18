using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotNet.DAL.Entities
{
    public class Author
    {
	    [BsonId]
	    public ObjectId InternalId { get; set; }

	    [BsonIgnore]
		public string AuthorId { get; set; }

	    [BsonElement("Name")]
		public string Name { get; set; }

	    [BsonElement("Books")]
		public ICollection<int> Books { get; set; }
    }
}
