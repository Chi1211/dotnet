using System.Collections.Generic;

namespace asprazor03{
    public class ProductListService{
        public List<ProductModel> product=new List<ProductModel>(){
            new ProductModel(){ Name="Samsung", Descripts="Đời mới", Price=50000000},
            new ProductModel(){ Name="Iphone", Descripts="Đời cũ", Price=90000000},
            new ProductModel(){ Name="Nokia", Descripts="Đời mới", Price=20000000}
        };
    }
}