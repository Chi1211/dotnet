using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Migra{
public class ArticleTag{

    public int ArticleTagID{get; set;}

    
    public int ArticleID{get; set;}
    [ForeignKey("ArticleID")]
    public Article article{get; set;}
    public string TagID{get; set;}
     [ForeignKey("TagID")]
    public Tag tag{get; set;} 
}
}