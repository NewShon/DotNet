using AutoMapper;
using DotNet.BLL.Config;
using DotNet.BLL.Models;
using DotNet.WEB.Models;

namespace DotNet.WEB.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<BookViewModel, BookModel>().ReverseMap();
                config.CreateMap<AuthorViewModel, AuthorModel>().ReverseMap();
                config.CreateMap<GenreViewModel, GenreModel>().ReverseMap();

                MapperConfig.Initialize(config);
            });
        }
    }
}