using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class Contact: PageModel{
    [BindProperty(SupportsGet =true)]
    [DisplayName("Nhập ID")]
    [Range(1,100, ErrorMessage ="Errors")]
    public int UseID{get; set;}
    [BindProperty]
    [DisplayName("Nhập tên")]
   
    public string Name{get; set;}
    [BindProperty]
    [DisplayName("Nhập email")]
    [EmailAddress(ErrorMessage ="Bạn vui lòng nhập lại email")]
    public string Email{get; set;}
    private readonly ILogger<Contact> logger;
    public Contact(ILogger<Contact> _logger)
    {
        logger=_logger;
        logger.LogInformation("Logger contact");
        Console.Write("Logger contact");
    }

    // public int Tong(int a, int b)
    // {
    //     return a+b;
    // }
}
