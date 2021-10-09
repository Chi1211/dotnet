using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Entity{

    [Table("product")]
    public class ProductModel{
        [Required]
        [Key]
        public int ProductID{get; set;}
        [Required]
        [StringLength(50)]
        public string ProductName{get; set;}
        [StringLength(50)]
        public string Provider{ get; set;}

        public void PrintInfo()=> Console.WriteLine($"Tên: {ProductName}, Nhà cung cấp: {Provider}");
    }
}