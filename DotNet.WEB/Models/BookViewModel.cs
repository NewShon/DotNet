using System.Collections.Generic;

namespace DotNet.WEB.Models
{
    public class BookViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<string> Genres { get; set; }

        public List<string> Authors { get; set; }

        public string Description { get; set; }
    }
}