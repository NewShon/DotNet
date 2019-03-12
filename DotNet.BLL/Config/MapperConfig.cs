using AutoMapper;
using DotNet.BLL.Models;
using DotNet.DAL.Entities;

namespace DotNet.BLL.Config
{
    public class MapperConfig
    {
        public static void Initialize(IMapperConfigurationExpression config)
        {
            config.CreateMap<BookModel, Book>().ReverseMap();
            config.CreateMap<AuthorModel, Author>().ReverseMap();
            config.CreateMap<GenreModel, Genre>().ReverseMap();
        }
    }
}