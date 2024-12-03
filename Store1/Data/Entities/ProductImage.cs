using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Data.Entities
{
    [Table(nameof(ProductImage))]
    public class ProductImage
    {
        [Key]
        public int? Id { get; set; }
        [ForeignKey("Product")]
        public int? Productid { get; set; }
        [StringLength(500)]
        [Required]
        public string? ImagePath { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Product? Product { get; set; }
    }
}
