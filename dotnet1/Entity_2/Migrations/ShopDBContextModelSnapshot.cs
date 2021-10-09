﻿// <auto-generated />
using System;
using Entity_2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(ShopDBContext))]
    partial class ShopDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity_2.CategoryDetail", b =>
                {
                    b.Property<int>("CategoryDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UseId")
                        .HasColumnType("int");

                    b.HasKey("CategoryDetailID");

                    b.ToTable("categoryDetails");
                });

            modelBuilder.Entity("Entity_2.CategoryModel", b =>
                {
                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("ntext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Entity_2.ProductModel", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryModelCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasMaxLength(50)
                        .HasColumnType("money");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CategoryModelCategoryID");

                    b.HasIndex("Price")
                        .HasDatabaseName("index-product-price");

                    b.ToTable("Sanpham");
                });

            modelBuilder.Entity("Entity_2.CategoryModel", b =>
                {
                    b.HasOne("Entity_2.CategoryDetail", "categoryDetail")
                        .WithOne("categoryModel")
                        .HasForeignKey("Entity_2.CategoryModel", "CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoryDetail");
                });

            modelBuilder.Entity("Entity_2.ProductModel", b =>
                {
                    b.HasOne("Entity_2.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entity_2.CategoryModel", null)
                        .WithMany("product")
                        .HasForeignKey("CategoryModelCategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entity_2.CategoryDetail", b =>
                {
                    b.Navigation("categoryModel");
                });

            modelBuilder.Entity("Entity_2.CategoryModel", b =>
                {
                    b.Navigation("product");
                });
#pragma warning restore 612, 618
        }
    }
}
