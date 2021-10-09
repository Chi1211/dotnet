using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asprazor05
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public UserModel userModel {get; set;}
        public void OnGet()
        {
        }
    }
}
