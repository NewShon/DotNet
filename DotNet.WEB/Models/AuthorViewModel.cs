using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNet.WEB.Models
{
    public class AuthorViewModel
    {
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public List<string> Books { get; set; }
    }
}