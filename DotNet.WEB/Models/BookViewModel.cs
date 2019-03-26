using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNet.WEB.Models
{
    public class BookViewModel
    {
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Id is required")]
        public string Name { get; set; }

        public List<string> Genres { get; set; }

        public List<string> Authors { get; set; }

        public string Description { get; set; }
    }
}