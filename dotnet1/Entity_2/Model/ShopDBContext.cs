using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Entity_2{
    
    public class ShopDBContext: DbContext
    {
        public static readonly ILoggerFactory loggerFactory= LoggerFactory.Create(builder =>{
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        }
        
        );
        public DbSet<ProductModel> productModels {get; set;}
        public DbSet<CategoryModel> categoryModels{get; set;}
        public DbSet<CategoryDetail> categoryDetails{get; set;}
        private const string connectString=@"Data Source=DESKTOP-UE12GR7;Initial Catalog=Shopdb;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(connectString);
            // optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API

            //khởi tạo entity
            // modelBuilder.Entity(typeof(ProductModel));
            // modelBuilder.Entity<ProductModel>();
            modelBuilder.Entity<ProductModel>( entity =>{
                // Tạo bảng product
                entity.ToTable("Sanpham");
                //pk
                entity.HasKey(p=> p.ProductID);
                // Index: đánh chỉ mục để tăng tốc truy vấn
                entity.HasIndex(p=>p.Price).HasDatabaseName("index-product-price");

                // FK
                entity.HasOne(p=> p.Category).WithMany().HasForeignKey("CategoryID").OnDelete(DeleteBehavior.Cascade);
                entity.Property(p=>p.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
            );

            modelBuilder.Entity<CategoryDetail>(entity=>{
                entity.HasOne(c=> c.categoryModel)
                .WithOne(c=>c.categoryDetail)
                .HasForeignKey<CategoryModel>(c=>c.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);
            });



        }

    }
}