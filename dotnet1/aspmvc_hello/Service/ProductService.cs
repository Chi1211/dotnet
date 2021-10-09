using System.Collections.Generic;
using aspmvc_hello.Models;
namespace aspmvc_hello.Service
{
    public class ProductService{
        public List<ProductModel> product=new List<ProductModel>(){
            new ProductModel(){id=1, name="Iphone X", price=20000000},
            new ProductModel(){id=2, name="Samsung 6S", price=25000000},
            new ProductModel(){id=3, name="Nokia", price=5000000},
            new ProductModel(){id=4, name="Redmi", price=6000000},
            new ProductModel(){id=5, name="Iphone 8", price=10000000},
            new ProductModel(){id=6, name="Samsung 8S", price=30000000},
        };
    }
}