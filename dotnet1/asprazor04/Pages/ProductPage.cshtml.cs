using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyApp.Namespace
{
    public class ProductPageModel : PageModel
    {
        public ProductService productService;
        private readonly ILogger<ProductPageModel> logger;
        public ProductPageModel(ILogger<ProductPageModel> _logger, ProductService _productService)
        {
            logger=_logger;
            productService=_productService;
        }
        public Product product{get; set;}
        public void OnGet(int? id,[Bind("Id")] Product sanpham)
        {
            Console.WriteLine($"ID: {sanpham.Id}");
            if(id!=null)
            {
                product=productService.Find(id.Value);
                
            }else
            {
                productService.AllProduct();
            }
        }
    }
}
