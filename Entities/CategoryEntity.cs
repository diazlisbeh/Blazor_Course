using System.ComponentModel.DataAnnotations;

namespace Blazor_Course.Entities
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public string CategotyId { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName{ get; set; }
        public ICollection<ProductEntity> Products {get;set;} 
    }
}