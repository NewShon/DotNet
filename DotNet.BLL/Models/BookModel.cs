﻿using System.Collections.Generic;

namespace DotNet.BLL.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<AuthorModel> Authors { get; set; }

        public ICollection<GenreModel> Genres { get; set; }

        public string Description { get; set; }
    }
}
