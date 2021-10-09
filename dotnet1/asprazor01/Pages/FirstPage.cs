using Microsoft.AspNetCore.Mvc.RazorPages;

public class FirstPageModel : PageModel{
    public string title {get;set;}="XIN CHÀO VÕ THỊ BÍCH CHI";
    public void OnGet(){
        ViewData["mydata"]="Good morning";
    }

    public void OnGetXYZ(){
        ViewData["mydata"]="Good afternoon";
    }
}