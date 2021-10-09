using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Article{
    [Key]
    public int Id{get; set;}
    [StringLength(255)]
    [Column(TypeName="nvarchar")]
    [Required]
    public string Title{get; set;}
    [Required]
    [DataType(DataType.Date)]
    public DateTime Created{get; set;}
    [Column(TypeName ="ntext")]
    public string Content{get; set;}
}