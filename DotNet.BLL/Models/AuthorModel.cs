using System.Collections.Generic;

namespace DotNet.DAL.Entities
{
    public class AuthorModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<BookModel> Books { get; set; }
    }
}
