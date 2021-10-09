using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Entity_2
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            
            // InsertDatabase();
            Generic.DropDatabase();
            Generic.CreatedDatabase();
            // CategoryType.InsertDatabase();
            // ProductType.InsertDatabase();
            //Logging

            // using var dbcontext=new ShopDBContext();

            // In thông tin category khi có product
            // var product=(from pro in dbcontext.productModels where pro.ProductID==3 select pro).FirstOrDefault();
            // product.PrintInfo();
            // var entry=dbcontext.Entry(product);
            // entry.Reference(product=>product.Category).Load();
            // if(product.Category !=null)
            // {
            //     Console.WriteLine(product.Category.Name);
            // }else {Console.WriteLine("Category==null");}

            //In thông tin product khi có Cate

            // var category=(from cate in dbcontext.categoryModels where cate.CategoryID==1 select cate).FirstOrDefault();
            // // var entry=dbcontext.Entry(category);
            // // entry.Collection(c=> c.product).Load();
            // if(category.product!=null)
            // {
            //     category.product.ForEach(p=>p.PrintInfo());
            // }else{
            //     Console.WriteLine($"Loại {category.Name} không có sản phẩm nào");
            // }
            // var p=dbcontext.productModels.Find(1);
            // p.PrintInfo();


            //Fluent API

        }
    }
}
