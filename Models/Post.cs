using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_entityframework.Models
{
    [Table("Post")]
    public class Post 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        // Criando uma referencia de navecação com chave estrangeira
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Isso é uma referencia de navecação.

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }        
    }
}