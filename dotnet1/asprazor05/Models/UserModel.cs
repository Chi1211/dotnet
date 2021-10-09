using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class UserModel{
    [Required]
    [DisplayName("ID")]
    public int Id{get; set;}
    [DisplayName("Name")]
    [Required]
    [StringLength(50,MinimumLength =1, ErrorMessage =" Dài từ 1-50 kí tự")]
    [ModelBinder(BinderType = typeof(UserNameBinding))]
    public string Name{get; set;}
    [DisplayName("Gmail")]
    [Required]
    [EmailAddress(ErrorMessage ="Bạn nhập email")]
    public string Email{get; set;}
   
    [DisplayName("Birthday")]
    [WithinSixYears]
    public DateTime? Birthday{get; set;}
}
public class WithinSixYearsAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        value = (DateTime)value;
        // This assumes inclusivity, i.e. exactly six years ago is okay
        if (DateTime.Now.AddYears(-150).CompareTo(value) <= 0 && DateTime.Now.CompareTo(value) >= 0)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult("Date must be within the last 150 years!");
        }
    }
}