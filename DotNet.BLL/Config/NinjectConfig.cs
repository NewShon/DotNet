using DotNet.DAL.Entities;
using DotNet.DAL.Interfaces;
using DotNet.DAL.Repositories;
using Ninject;

namespace DotNet.BLL.Config
{
    public static class NinjectConfig
    {
        public static void AddBindings(IKernel kernel)
        {
            kernel.Bind<IRepository<Book>>().To<BookRepository>();
            kernel.Bind<IRepository<Author>>().To<AuthorRepository>();
            kernel.Bind<IRepository<Genre>>().To<GenreRepository>();
        }
    }
}
