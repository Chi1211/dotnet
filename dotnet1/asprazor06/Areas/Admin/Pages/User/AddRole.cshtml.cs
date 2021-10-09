using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using asprazor06;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.Admin.User
{
    [AllowAnonymous]
    public class AddRoleModel : PageModel
    {
        public string StatusMessage{get; set;}
        private readonly UserManager<asprazor06.User> _userManager;
        private readonly SignInManager<asprazor06.User> _signInManager;
        
        private readonly RoleManager<IdentityRole> _roleManager;

        public SelectList allRole{get;set;}
        public AddRoleModel(UserManager<asprazor06.User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<asprazor06.User> signInManager)
        {
            _signInManager=signInManager;
            _userManager = userManager;
            _roleManager=roleManager;
        }
        [BindProperty]
        [Display(Name ="Các name gán cho user")]
        public string[] roleName{get; set;}
        public asprazor06.User users{get; set;}
        public async Task<IActionResult> OnGet(string roleid)
        {
            if (roleid == null)
            {
                return NotFound();
            }
            users = await _userManager.FindByIdAsync(roleid);
            if(users==null)
            {
                return NotFound();

            }

            roleName= (await _userManager.GetRolesAsync(users)).ToArray();

            List<string> rolename=await _roleManager.Roles.Select(r=> r.Name).ToListAsync();
            allRole=new SelectList(rolename);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string roleid)
        {
            if(roleid==null)
            {
                return NotFound();
            }
            var user=await _userManager.FindByIdAsync(roleid);
            if(user==null)
            {
                return NotFound();
            }
            var oldRole=(await _userManager.GetRolesAsync(user)).ToArray<string>();
            // roleName
            var delerole=oldRole.Where(role=> !roleName.Contains(role));
            var addrole=roleName.Where(role=> !oldRole.Contains(role));

            var result= await _userManager.RemoveFromRolesAsync(user, delerole);
            if(result.Succeeded)
            {
               
                return Page();
            }else{
                result.Errors.ToList().ForEach(e=>{
                    ModelState.AddModelError(string.Empty, e.Description);
                });
            }
         

            result= (await _userManager.AddToRolesAsync(user, addrole));
            if(result.Succeeded)
            {
               
                return Page();
            }else{
                result.Errors.ToList().ForEach(e=>{
                    ModelState.AddModelError(string.Empty, e.Description);
                });
            }
            StatusMessage="Update role succesed";
            return Page();

        }
    }
}
