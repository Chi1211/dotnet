[Key]
        public int ID{ get; set;}

        [Column(TypeName ="nvarchar")]
        [Display(Name ="Họ và tên")]
        [Required]
        [StringLength(50, ErrorMessage ="Độ dài nhỏ hơn 50 kí tự")]
        public string FullName{get; set;}

        [EmailAddress]
        [Display(Name ="Email")]
        [Required]
        public string Email{get; set;}

        [WithinYears]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DateSend{get; set;}
        [Column(TypeName ="ntext")]
        public string Message{get; set;}

    

// Xây dựng attribute
public class WithinYearsAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        value = (DateTime)value;
        // This assumes inclusivity, i.e. exactly six years ago is okay
        if (DateTime.Now.CompareTo(value) >= 0)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult("Ngày nhập nhỏ hơn ngày hiện tại!");
        }
    }
}