using Core.Api.Entities.Concrete;
using Core.Api.Entities.ContextTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Api.DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepositoy<Article>
    {
        List<Article> GetArticleDetailList();
        Article GetArticleDetail(int articleId);
    }
}
