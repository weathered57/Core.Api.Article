using Core.Api.DataAccess.Abstract;
using Core.Api.Entities.Concrete;
using Core.Api.Entities.ContextTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Api.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, ArticleContext>, IArticleDal
    {
        public Article GetArticleDetail(int articleId)
        {
            using (ArticleContext context = new ArticleContext())
            {
                var article = context.Articles.Include(x => x.ArticleType).FirstOrDefault(x=>x.ArticleId == articleId);
                return article;
            }
        }


        public List<Article> GetArticleDetailList()
        {
            using (ArticleContext context = new ArticleContext())
            {
                var article = context.Articles.Include(x => x.ArticleType).ToList();
                return article;
            }

        }


    }
}
