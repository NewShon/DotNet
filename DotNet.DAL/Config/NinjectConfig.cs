using System.Configuration;
using DotNet.DAL.Context;
using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using DotNet.DAL.Repositories;
using Ninject;

namespace DotNet.DAL.Config
{
    public static class NinjectConfig
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IRepository<Book>>().To<BookRepository>();
            kernel.Bind<IRepository<Author>>().To<AuthorRepository>();
            kernel.Bind<IRepository<Genre>>().To<GenreRepository>();

#if DEBUG
			// Azure
	        var server = ConfigurationManager.AppSettings["AzureServer"];
	        var databse = ConfigurationManager.AppSettings["AzureDatabase"];
#elif (!DEBUG)
			var server = ConfigurationManager.AppSettings["AzureServer"];
	        var databse = ConfigurationManager.AppSettings["AzureDatabase"];
#endif

			kernel.Bind<MongoDBContext>().To<MongoDBContext>()
				.WithPropertyValue(server, databse);
		}
	}
}
