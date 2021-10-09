using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Entity
{
    class Program
    {
        static void CreatedDatabase(){
            using var dbcontext= new ProductDBContext();;
            string dbname=dbcontext.Database.GetDbConnection().Database;
            var result=dbcontext.Database.EnsureCreated();
            if(result)
            {
                Console.WriteLine($"{dbname} db Created");
            }else{
                Console.WriteLine($"{dbname} db not create");
            }
        }
        static void DropDatabase(){
            using var dbcontext=new ProductDBContext();
            string dbname=dbcontext.Database.GetDbConnection().Database;
            var result=dbcontext.Database.EnsureDeleted();
            if(result)
            {
                Console.WriteLine($"{dbname} delete successed");
            }else{
                Console.WriteLine($"{dbname} delete no successed");
            }
        }
        static void InsertDatabase(){
            using var dbcontext=new ProductDBContext();
            IList<ProductModel> productlist= new List<ProductModel>();
            Console.Write("Nhập số lượng sản phẩm: ");
            int n=Int32.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.Write("Nhập tên sản phẩm: ");
                string name=Console.ReadLine();
                Console.Write("Nhập nhà cung cấp: ");
                string provider=Console.ReadLine();
                ProductModel pro= new ProductModel();
                pro.ProductName=name;
                pro.Provider=provider;
                productlist.Add(pro);
            }
            dbcontext.AddRange(productlist);
            var result=dbcontext.SaveChanges();
            Console.WriteLine($"Insert {result} successed");
            
        }
        static void ReadDatabase(){
            using var dbcontext=new ProductDBContext();
            //Linq
            ProductModel product=(from products in dbcontext.productModels select products).FirstOrDefault();
            // product.ToList().ForEach(product=> product.PrintInfo());
            if(product!=null)
            {
                product.PrintInfo();
            }
        }
        static void RenameDatabase(int id, string name){
            using var dbcontext=new ProductDBContext();
            var product=(from products in dbcontext.productModels 
                        where products.ProductID==id
                        select products).FirstOrDefault();
            // foreach(var item in product)
            // {
            //     item.ProductName=name;
            //     int rs=dbcontext.SaveChanges();
            //     Console.WriteLine($"Sửa {rs} hàng");
            // }
            if(product!=null)
            {
                product.ProductName=name;
                int rs=dbcontext.SaveChanges();
                 Console.WriteLine($"Sửa {rs} hàng");
            }else{
                Console.WriteLine("Không sửa tên");
            }

        }
        static void DeleteDatabase(int id)
        {
            using var dbcontext=new ProductDBContext();
            var product=(from products in dbcontext.productModels 
                        where products.ProductID==id
                        select products).FirstOrDefault();

            if(product!=null)
            {
                dbcontext.Remove(product);
                int col=dbcontext.SaveChanges();
                Console.WriteLine($"Delete {col}");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            // CreatedDatabase();
            // DropDatabase();
             InsertDatabase();
            // ReadDatabase();
            // RenameDatabase(1,"Đường chính");
            // DeleteDatabase(4);

            //Logging

        }
    }
}
