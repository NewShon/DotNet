using System.Collections.Generic;

namespace DotNet.BLL.Models
{
    public class AuthorModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<string> Books { get; set; }
    }
}
