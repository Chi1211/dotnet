using System;
using System.Collections.Generic;


namespace Entity_2{
    public class CategoryType{
            public static void InsertDatabase(){
                var dbcontext=new ShopDBContext();
                IList<CategoryModel> list=new List<CategoryModel>();
            
            for(int i=0;i<5;i++)
            {
                Console.Write("Nhập tên loại: ");
                string name=Console.ReadLine();
                Console.Write("Nhập mô tả");
                string des=Console.ReadLine();
                CategoryModel cate=new CategoryModel();
                cate.Name=name;
                cate.Description=des;
                list.Add(cate);
            }
            dbcontext.AddRange(list);
            int col=dbcontext.SaveChanges();
            Console.WriteLine($"Insert {col} Category db");
        }
    }
}