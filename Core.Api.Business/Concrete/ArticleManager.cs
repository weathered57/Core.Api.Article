using Core.Api.Business.Abstract;
using Core.Api.DataAccess.Abstract;
using Core.Api.Entities.Concrete;
using Core.Api.Entities.ContextTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Api.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public List<Article> GetAll()
        {
            return _articleDal.GetList();
        }

        public Article Get(int articleId)
        {
            return _articleDal.GetList(x => x.ArticleId == articleId).SingleOrDefault();
        }

        public void Add(Article product)
        {
            _articleDal.Add(product);
        }

        public void Delete(int articleId)
        {
            _articleDal.Delete(new Article { ArticleId = articleId });
        }

        public void Update(Article product)
        {
            _articleDal.Update(product);
        }

        public List<ArticleModelDTO> GetAllDetail()
        {
            return _articleDal.GetArticleDetailList();
        }

        public ArticleModelDTO GetDetail(int articleId)
        {
            return _articleDal.GetArticleDetail(articleId);
        }
    }
}
