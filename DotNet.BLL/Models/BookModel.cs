using System.Collections.Generic;

namespace DotNet.BLL.Models
{
    public class BookModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<string> Authors { get; set; }

        public ICollection<string> Genres { get; set; }

        public string Description { get; set; }
    }
}
