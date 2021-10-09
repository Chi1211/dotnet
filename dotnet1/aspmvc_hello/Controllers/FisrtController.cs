using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspmvc_hello.Service;
using System.Linq;

namespace aspmvc_hello.Controllers
{
    public class FirstController: Controller {

        ILogger<FirstController> _logger;
        ProductService _productService;
        public FirstController(ILogger<FirstController> logger, ProductService productService)
        {
            _logger=logger;
            _productService=productService;
        }
        [TempData]
        public string StatusMessage{get; set;}
        public IActionResult Hello(string username){
            if(string.IsNullOrEmpty(username)){
                username="Chi";
            }
            _logger.LogInformation("In thành công");
            return View((object)username);
        }

        public IActionResult Product(int? id)
        {
            if(id==null)
            {
                StatusMessage="Không có id";
                return NotFound("Không có sản phẩm");
            }

            var product=_productService.product.Where(p=> p.id==id).ToList();
            if(product==null)
            {
                StatusMessage=$"Không có sảng phẩm nào id={id}";
                return NotFound();
            }
            return View("Hello",product);
        }

    }
}