using System.Collections.Generic;
using System.Linq;

public class ProductService{
    public List<Product> product=new List<Product>(){
        new Product(){Id=1, Name="Samsung", Description="Đời mới", Price=2000000},
        new Product(){Id=2, Name="Iphone", Description="Đời mới", Price=2000000},
        new Product(){Id=3, Name="Nokia", Description="Đời mới", Price=2000000},
        new Product(){Id=4, Name="Redmi", Description="Đời mới", Price=1000000},
        new Product(){Id=5, Name="Samsung", Description="Đời cũ", Price=200000}
    };

    public Product Find(int id){
        var query=(from pro in product where pro.Id==id select pro).FirstOrDefault();
        return query;
    }

    public List<Product> AllProduct(){
        return product;
    }

    
}