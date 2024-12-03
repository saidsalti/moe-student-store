using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Data.Entities
{

    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        public int? Id { get; set; }
        [StringLength(128)]
        [Required]
        public  string? NameAr { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public DateTime? Create { get; set; }
        public virtual Category? Category { get; set; }


    }
}
