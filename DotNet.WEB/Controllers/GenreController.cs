﻿using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace DotNet.WEB.Controllers
{
    public class GenreController : ApiController
    {

        private IGenreService genreService;


        public GenreController(IGenreService genreService)
        {
            this.genreService = genreService;
        }



        // GET: api/Genre
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Genre/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Genre
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Genre/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Genre/5
        public void Delete(int id)
        {
        }
    }
}
