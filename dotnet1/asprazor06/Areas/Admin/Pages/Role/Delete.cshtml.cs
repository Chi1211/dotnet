using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using asprazor06;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace App.Admin.Role
{
    public class DeleteModel : RolePageModel
    {

        public DeleteModel(RoleManager<IdentityRole> roleManager, NewsDBContext newsDBContext)
        :base(roleManager, newsDBContext)
        {

        }
         [BindProperty]
        public InputModel Input{get; set;}
          public class InputModel{
            [Display(Name ="Name role: ")]
            [Required(ErrorMessage ="Phải nhập")]
            [StringLength(100, ErrorMessage ="{0} lengh from {2} to {1}", MinimumLength =2)]
            public string Name{get; set;}

        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string roleid)
        {

            if(roleid==null)
            {
                return NotFound();
            }

            var role=await _roleManager.FindByIdAsync(roleid);
            if(role==null)
            {
                return Page();
            }

            var result=await _roleManager.DeleteAsync(role);

            if(result.Succeeded)
            {
                StatusMessage="Delete successed";
            }
            else{
                result.Errors.ToList().ForEach(error=>{
                    ModelState.AddModelError(string.Empty, error.Description);
                });
            }
            return Page();
        }
    }
}
