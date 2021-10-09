using System;
using System.Collections.Generic;

namespace Entity_2{
    public class ProductType{
            public static void InsertDatabase(){
             var dbcontext=new ShopDBContext();
                IList<ProductModel> list=new List<ProductModel>();
            
            for(int i=0;i<5;i++)
            {
                Console.Write("Nhập tên sản phẩm: ");
                string name=Console.ReadLine();
                Console.Write("Nhập giá");
                decimal price=Decimal.Parse(Console.ReadLine());
                Console.Write("Nhập loại sản phẩm: ");
                int categoryId=Int32.Parse(Console.ReadLine());
                ProductModel pro=new ProductModel();
                pro.Name=name;
                pro.Price=price;
                // pro.CategoryID=categoryId;
                list.Add(pro);
            }
            dbcontext.AddRange(list);
            int col=dbcontext.SaveChanges();
            Console.WriteLine($"Insert {col}");
        }
    }
}