using AutoMapper;
using DotNet.BLL.Models;
using DotNet.DAL.Entities;
using MongoDB.Bson;

namespace DotNet.BLL.Config
{
    public class MapperConfig
    {
        public static void Initialize(IMapperConfigurationExpression config)
        {
            config.CreateMap<BookModel, Book>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => ObjectId.Parse(src.Id)))
                .ReverseMap();

            config.CreateMap<AuthorModel, Author>()
            .ForMember(dest => dest.Id, opts => opts.MapFrom(src => ObjectId.Parse(src.Id)))
                .ReverseMap();

            config.CreateMap<GenreModel, Genre>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => ObjectId.Parse(src.Id)))
                .ReverseMap();

        }
    }
}