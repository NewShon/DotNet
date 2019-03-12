using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace DotNet.WEB.Controllers
{
    public class AuthorController : ApiController
    {

        private IService<AuthorModel> authorService;


        public AuthorController(IService<AuthorModel> authorService)
        {
            this.authorService = authorService;
        }


        
        // GET: api/Author
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Author/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Author
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Author/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Author/5
        public void Delete(int id)
        {
        }
    }
}
