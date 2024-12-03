using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Data.Entities
{
    [Table(nameof(Category))]
    public class Category
    {
   
        [Key]
        public int? Id { get; set; }
        public string? NameAr { get; set; }
        public string? ImagePath { get; set; }
        public int? OrderIndex { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual ICollection<Product>? Products { get; set; }


    }
}
