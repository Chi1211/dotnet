using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace asprazor03.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public ProductModel product= new ProductModel(){ Name="Samsung", Descripts="Đời mới", Price=50000000};
        public ProductModel product2= new ProductModel(){ Name="Samsung", Descripts="Đời mới", Price=50000000};
        public ProductModel product3= new ProductModel(){ Name="Samsung", Descripts="Đời mới", Price=50000000};
    }
}
