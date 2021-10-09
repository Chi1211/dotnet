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
    public class EditModel : RolePageModel
    {

        public EditModel(RoleManager<IdentityRole> roleManager, NewsDBContext newsDBContext )
        :base(roleManager, newsDBContext)
        {

        }

        [BindProperty]
        public InputModel Input{get; set;}
        public class InputModel{
            [Display(Name="Name role")]
            [Required]
            [StringLength(256,ErrorMessage ="{0} from {2} to {1}", MinimumLength =2 )]
            public string Name{get; set;}
        }
        public async Task<IActionResult> OnGetAsync(string roleid)
        {
            if(roleid==null){
                return NotFound();
            }
            var role=await _roleManager.FindByIdAsync(roleid);
            if(role!=null)
            {
                Input=new InputModel(){
                    Name=role.Name
                };
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string roleid ){
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var role=await _roleManager.FindByIdAsync(roleid);
            if(role==null)
            {
                return Page();
            }
            role.Name=Input.Name;
            var result= await _roleManager.UpdateAsync(role);
            if(result.Succeeded)
            {
                StatusMessage="Update success";
                return RedirectToPage("./Index");
            }else{
                result.Errors.ToList().ForEach(error=>{
                ModelState.AddModelError(string.Empty, error.Description);
                }) ;
            }
            return Page();
        }


    }
}
