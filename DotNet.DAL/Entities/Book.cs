using System.Collections.Generic;

namespace DotNet.DAL.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Author> Authors{ get; set; }

        public ICollection<Genre> Genres { get; set; }

        public string Description { get; set; }
    }
}
