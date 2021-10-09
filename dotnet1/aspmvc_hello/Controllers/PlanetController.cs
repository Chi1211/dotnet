using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspmvc_hello.Service;
using aspmvc_hello.Models;
using System.Linq;

namespace aspmvc_hello.Controllers
{
    public class PlanetController: Controller
    {
        ILogger<PlanetController> _logger;
        PlanetService _planetService;
        public PlanetController(ILogger<PlanetController> logger, PlanetService planetService )
        {
            _logger=logger;
            _planetService=planetService;
        }
        [TempData]
        public string StatusMessage{get; set;}
        [Route("/list_planet.html")]
        public IActionResult OnGetAll()
        {
            return View("Planet");

        }
        [Route("/list_planet/{id:int}.html", Name="detail")]
        public  IActionResult OnGetDetail(int id)
        {
            if(id==null)
            {
                StatusMessage="Không có tham sô";
                return NotFound();
            }
            var detail= _planetService.planet.Where(p=> p.id==id).FirstOrDefault();
            if(detail==null)
            {
                StatusMessage="Không tìm thấy";
                return NotFound();
            }

            return View("Detail", detail);
        }

    }
}