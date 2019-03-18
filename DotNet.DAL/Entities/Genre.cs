using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotNet.DAL.Entities
{
    public class Genre
    {
	    [BsonId]
	    public ObjectId InternalId { get; set; }

	    [BsonIgnore]
		public string GenreId { get; set; }

	    [BsonElement("Name")]
		public string Name { get; set; }
    }
}
