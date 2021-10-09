using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using asprazor06;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace App.Admin.User
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<asprazor06.User> _userManager;
        private readonly NewsDBContext _newsDBContext;
        [TempData]
        public string StatusMessage{get; set;}
        public IndexModel(UserManager<asprazor06.User> userManager, NewsDBContext newsDBContext)
        {
            _userManager = userManager;
            _newsDBContext = newsDBContext;
        }
        public List<asprazor06.User> users{get; set;}
        public async Task OnGetAsync()
        {
            // roles=await _userManager.UserRoles.ToListAsync();
            users=await _userManager.Users.ToListAsync();
        }

     
    }
}
