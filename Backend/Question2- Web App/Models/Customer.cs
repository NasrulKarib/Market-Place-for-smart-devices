using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Question2__Web_App.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Column("CustomerName", TypeName = "varchar(20)")]
        [Required]
        public string? Name { get; set; }

        
        [Column("CustomerDetails", TypeName = "varchar(50)")]
        [Required]
        public string? Details { get; set; }

        [Column("CustomerAge", TypeName = "int")]
        [Required]
        public int? Age { get; set; }

        [Column("CustomerMail", TypeName = "varchar(50)")]
        [Required]
        public string? Mail { get; set; }
    }
}
