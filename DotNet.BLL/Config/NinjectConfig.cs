using DotNet.BLL.Interfaces;
using DotNet.BLL.Models;
using DotNet.BLL.Services;
using Ninject;

namespace DotNet.BLL.Config
{
    public static class NinjectConfig
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IBookService>().To<BookService>();
            kernel.Bind<IAuthorService>().To<AuthorService>();
            kernel.Bind<IGenreService>().To<GenreService>();

            DAL.Config.NinjectConfig.Register(kernel);
        }
    }
}
