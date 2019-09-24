using Core.Api.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Api.Business.Abstract
{
    public interface IArticleService
    {
        List<Article> GetAll();
        Article Get(int articleId);
        void Add(Article product);
        void Update(Article product);
        void Delete(int articleId);
    }
}
