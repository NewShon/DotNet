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

                MapperConfig.Initialize(config);
            });
        }
    }
}