using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNet.WEB.Models
{
    public class GenreViewModel
    {
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Id is required")]
        public string Name { get; set; }

    }
}