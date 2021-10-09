using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entity_2{
    [Table("Category")]
    public class CategoryModel{
        [Key]
        public int CategoryID{get; set;}
        [Required]
        [StringLength(50)]
        [Column(TypeName ="nvarchar")]
        public string Name{get; set;}
        [Required]
        [StringLength(50)]
        [Column(TypeName ="ntext")]
        public string Description{get;set;}

        // Collect Nagative
        public virtual List<ProductModel> product{get; set;}
        public CategoryDetail categoryDetail{get; set;}
    }
}

// Collect Nagative
// Reference Nagative