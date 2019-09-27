using Core.Api.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Api.Entities.Concrete
{
   public class ArticleType : IEntity
    {
        public int ArticleTypeId { get; set; }
        public string ArticleTypeName { get; set; }
    }
}
