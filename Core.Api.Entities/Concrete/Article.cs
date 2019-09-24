using Core.Api.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Api.Entities.Concrete
{
    public class Article : IEntity
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleType { get; set; }
        public string ArticleSummary { get; set; }
        public DateTime ArticleAddedDate { get; set; }
    }
}
