using System.Collections.Generic;

namespace DotNet.WEB.Models
{
    public class AuthorViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<string> Books { get; set; }
    }
}