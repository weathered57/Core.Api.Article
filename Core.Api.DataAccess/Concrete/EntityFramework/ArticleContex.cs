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
            optionsBuilder.UseSqlServer(@"Server=77.245.159.15\MSSQLSERVER2012;Initial Catalog=anilcan_;User Id=anilcan;password=05436467210Tr10");
        }

        public DbSet<Article> Articles { get; set; }
    }
}
