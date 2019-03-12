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
            kernel.Bind<IService<BookModel>>().To<BookService>();
            kernel.Bind<IService<AuthorModel>>().To<AuthorService>();
            kernel.Bind<IService<GenreModel>>().To<GenreService>();

            DAL.Config.NinjectConfig.Register(kernel);
        }
    }
}
