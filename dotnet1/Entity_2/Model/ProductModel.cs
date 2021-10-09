using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Entity_2{

    // [Table("Product")]
    public class ProductModel{
        // [Required]
        // [Key]
        public int ProductID{get; set;}
        [Required]
        [StringLength(50)]
        [Column(TypeName ="nvarchar")]
        public string Name{get; set;}
        [StringLength(50)]
        [Column(TypeName ="money")]
        public decimal Price{ get; set;}
        // public int? CategoryID{get; set;}
        // // ForienKey
        public virtual CategoryModel Category {get; set;}

        public void PrintInfo()=> Console.WriteLine($"Tên: {Name}, Nhà cung cấp: {Price}");
    }
}