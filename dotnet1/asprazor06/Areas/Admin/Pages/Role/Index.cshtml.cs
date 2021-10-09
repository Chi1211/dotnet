using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using asprazor06;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Admin.Role
{
    public class IndexModel : RolePageModel
    {

        public IndexModel(RoleManager<IdentityRole> roleManager, NewsDBContext newsDBContext)
        :base(roleManager, newsDBContext)
        {

        }
        public List<IdentityRole> roles{get; set;}
        public async Task OnGetAsync()
        {
            roles=await _roleManager.Roles.ToListAsync();
        }
    }
}
