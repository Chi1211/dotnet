
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace asprazor06{
public class RolePageModel: PageModel
{
    protected readonly RoleManager<IdentityRole> _roleManager;
    protected readonly NewsDBContext _newsDBContext;
    [TempData]
    public string StatusMessage{get; set;}
    public RolePageModel(RoleManager<IdentityRole> roleManager, NewsDBContext newsDBContext)
    {
        _roleManager=roleManager;
        _newsDBContext=newsDBContext;
    }
}
}