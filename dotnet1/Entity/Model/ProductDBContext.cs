using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Entity{
    
    public class ProductDBContext: DbContext
    {
        public static readonly ILoggerFactory loggerFactory= LoggerFactory.Create(builder =>{
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        }
        
        );
        public DbSet<ProductModel> productModels {get; set;}
        private const string connectString=@"Data Source=DESKTOP-UE12GR7;Initial Catalog=Product;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(connectString);
        }

    }
}