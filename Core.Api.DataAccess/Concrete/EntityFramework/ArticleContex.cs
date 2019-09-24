using Core.Api.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Api.DataAccess.Concrete.EntityFramework
{
    public class ArticleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=fornax.pennaict.com;Initial Catalog=deneme;User Id=sa;password=*-P2e0+N1n4!@-*;Trusted_Connection=true");
        }

        public DbSet<Article> Articles { get; set; }
    }
}
