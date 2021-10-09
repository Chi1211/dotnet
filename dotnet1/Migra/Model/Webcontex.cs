using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Migra
{
    public class WebContext : DbContext
    
    {
        public static readonly ILoggerFactory loggerFactory= LoggerFactory.Create(builder =>{
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        }
        
        );
        public DbSet<Article> articles {set; get;}        // bảng article
        public DbSet<Tag> tags {set; get;}                // bảng tag

        public DbSet<ArticleTag> articleTags{get; set;}

        // chuỗi kết nối với tên db sẽ làm  việc đặt là webdb
        public const string ConnectStrring  =@"Data Source=DESKTOP-UE12GR7;Initial Catalog=Webdb;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(ConnectStrring);
             optionsBuilder.UseLoggerFactory(loggerFactory);       // bật logger
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ArticleTag>(entity =>{
                entity.HasIndex(articleTags=> new {articleTags.ArticleID, articleTags.TagID}).IsUnique();
            });
        }
        

        
        
    }

}