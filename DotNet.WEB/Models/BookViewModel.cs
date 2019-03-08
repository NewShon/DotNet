using System.Collections.Generic;

namespace DotNet.WEB.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<GenreViewModel> Genres { get; set; }

        public List<AuthorViewModel> Authors { get; set; }

        public string Description { get; set; }
    }
}