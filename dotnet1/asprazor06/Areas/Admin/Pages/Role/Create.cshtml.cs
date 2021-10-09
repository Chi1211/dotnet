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
    public class CreateModel : RolePageModel
    {

        

        public CreateModel(RoleManager<IdentityRole> roleManager, NewsDBContext newsDBContext)
        :base(roleManager, newsDBContext)
        {
        }
        [BindProperty]
        public InputModel Input{get; set;}
        public void OnGet()
        {
        }

        public class InputModel{
            [Display(Name ="Name role: ")]
            [Required(ErrorMessage ="Phải nhập")]
            [StringLength(100, ErrorMessage ="{0} lengh from {2} to {1}", MinimumLength =2)]
            public string Name{get; set;}

        }
        public async Task<IActionResult> OnPostAsync(){

            if(!ModelState.IsValid)
            {
                return Page();
            }
            var newrole=new IdentityRole(Input.Name);
            var result=await _roleManager.CreateAsync(newrole);
            if(result.Succeeded)
            {
                StatusMessage="Created succesed";
                return RedirectToPage("./Index");
            }else{
                result.Errors.ToList().ForEach(error=>{
                    ModelState.AddModelError(string.Empty, error.Description);
                });
                {
                    
                }
            }
            return Page();
        }
    }
}
