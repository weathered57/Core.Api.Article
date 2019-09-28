using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Api.Entities.ContextTypes
{
    public class ArticleModelDTO
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleTypeName { get; set; }
        public string ArticleSummary { get; set; }
    }
}
