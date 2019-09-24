using Core.Api.DataAccess.Abstract;
using Core.Api.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Api.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, ArticleContext>, IArticleDal
    {
    }
}
