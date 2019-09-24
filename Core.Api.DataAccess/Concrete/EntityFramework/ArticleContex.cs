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
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0V0427V\DATABASESERVER;Initial Catalog=ArticleTestDB;Trusted_Connection=true");
        }

        public DbSet<Article> Articles { get; set; }
    }
}
