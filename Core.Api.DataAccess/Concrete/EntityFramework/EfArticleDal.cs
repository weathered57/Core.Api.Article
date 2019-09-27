using Core.Api.DataAccess.Abstract;
using Core.Api.Entities.Concrete;
using Core.Api.Entities.ContextTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Api.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, ArticleContext>, IArticleDal
    {
        public ArticleModelDTO GetArticleDetail(int articleId)
        {
            using (ArticleContext context = new ArticleContext())
            {
                var result = (from a in context.Articles.Where(x => x.ArticleId == articleId).ToList()
                              join at in context.ArticleTypes
                              on a.ArticleTypeId equals at.ArticleTypeId
                              select new ArticleModelDTO
                              {
                                  ArticleName = a.ArticleName,
                                  ArticleSummary = a.ArticleSummary,
                                  ArticleTypeName = at.ArticleTypeName,
                              }).SingleOrDefault();
                return result;
            }
        }


        public List<ArticleModelDTO> GetArticleDetailList()
        {
            using (ArticleContext context = new ArticleContext())
            {
                var result = (from a in context.Articles
                              join at in context.ArticleTypes
                              on a.ArticleTypeId equals at.ArticleTypeId
                              select new ArticleModelDTO
                              {
                                  ArticleName = a.ArticleName,
                                  ArticleSummary = a.ArticleSummary,
                                  ArticleTypeName = at.ArticleTypeName,
                              }).ToList();
                return result;
            }

        }


    }
}
