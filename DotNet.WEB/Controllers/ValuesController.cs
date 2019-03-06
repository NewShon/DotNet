using System.Collections.Generic;
using System.Web.Http;

namespace DotNet.WEB.Controllers
{
	public class ValuesController : ApiController
	{
		private static List<string> _storage = new List<string>();

		// GET api/values
		public IEnumerable<string> Get()
		{
			return _storage;
		}

		// GET api/values/5
		public string Get(int id)
		{
			return _storage[id];
		}

		// PUT api/values
		public void Put(string str)
		{
			_storage.Add(str);
		}
	}
}
