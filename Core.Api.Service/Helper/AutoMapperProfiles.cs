using AutoMapper;
using Core.Api.Entities.Concrete;
using Core.Api.Entities.ContextTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Service.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Article, ArticleModelDTO>()
                .ForMember(dest => dest.ArticleTypeName, opt =>
                {
                    opt.MapFrom(src => src.ArticleType.ArticleTypeName);
                });
        }
    }
}
