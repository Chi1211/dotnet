using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspmvc_hello.Models;
using Microsoft.EntityFrameworkCore;

namespace aspmvc_hello.Area.Database.Controllers
{
    [Area("Database")]
    [Route("/database-manager/")]
    public class DBManagerController : Controller
    {
        AppDBContext _appDBContext;
        public DBManagerController(AppDBContext appDBContext)
        {
            _appDBContext=appDBContext;
        }
        [TempData]
        public string StatusMessage{get; set;}
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteDB(){
            View("DeleteDB");

            var result=_appDBContext.Database.EnsureDeleted();
            if(result)
            {
                StatusMessage="Xóa thành công";
            }else{
                StatusMessage="Xóa không thành công";
            }
            return  RedirectToAction(nameof(Index));

        }
        [Route("create")]
        [HttpGet]
        public async Task<IActionResult> CreateDB(){
            await _appDBContext.Database.MigrateAsync();
            StatusMessage="Tạo tành công";
        
            return RedirectToAction("Index");
        }
    }
}