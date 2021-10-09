using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migra
{
    [Table("article")]
    public class Article
    {
        [Key]
        public int ArticleId {set; get;}

        [StringLength(100)]
        public string Title {set;  get;}

    }
}