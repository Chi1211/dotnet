using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace asprazor03{
// [ViewComponent]
public class ProductBox: ViewComponent{

    // 1- khởi tạo Invoke or InvokeAsync
    //2- Khai báo [ViewComponent] or kế thừa ViewComponent[return string/IViewComponentResult]
    ProductListService _productListService;
    public ProductBox(ProductListService productListService)
    {
        _productListService=productListService;
    }
    public IViewComponentResult Invoke(bool sapxeptang=true){
        // List<ProductModel> products=new List<ProductModel>(){
        //     new ProductModel(){ Name="Samsung", Descripts="Đời mới", Price=80000000},
        //     new ProductModel(){ Name="Iphone", Descripts="Đời mới", Price=90000000},
        //     new ProductModel(){ Name="Nokia", Descripts="Đời mới", Price=50000000}
        // };
        List<ProductModel> _products=null;
        if(sapxeptang)
        {
            _products=_productListService.product.OrderBy(product=>product.Price).ToList();
        }else{
            _products=_productListService.product.OrderByDescending(product=>product.Price).ToList();
        }
        return View<List<ProductModel>>(_products); //Default.cshtml
    }
}
}